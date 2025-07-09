using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class datVenta
    {
        private static readonly datVenta _instancia = new datVenta();
        public static datVenta Instancia => _instancia;

        public bool RegistrarVenta(entVenta v)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spRegistrarVenta", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID", v.PedidoID);
                    cmd.Parameters.AddWithValue("@FechaVenta", v.FechaVenta);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<entVenta> ListarVentas()
        {
            List<entVenta> lista = new List<entVenta>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Venta WHERE Estado = 1", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new entVenta
                            {
                                VentaID = Convert.ToInt32(dr["VentaID"]),
                                PedidoID = Convert.ToInt32(dr["PedidoID"]),
                                FechaVenta = Convert.ToDateTime(dr["FechaVenta"]),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public void AnularVenta(int ventaID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spAnularVenta", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VentaID", ventaID);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
