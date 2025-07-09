using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datPedido
    {
        private static readonly datPedido _instancia = new datPedido();
        public static datPedido Instancia => _instancia;

        public bool RegistrarPedido(entPedido p)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spRegistrarPedido", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpresaID", p.EmpresaID);
                    cmd.Parameters.AddWithValue("@ProductoID", p.ProductoID);
                    cmd.Parameters.AddWithValue("@PresentacionID", p.PresentacionID);
                    cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                    cmd.Parameters.AddWithValue("@FechaPedido", p.FechaPedido);
                    cn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<entPedido> ListarPedidos()
        {
            List<entPedido> lista = new List<entPedido>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("spListarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entPedido
                    {
                        PedidoID = Convert.ToInt32(dr["PedidoID"]),
                        EmpresaID = Convert.ToInt32(dr["EmpresaID"]),
                        EmpresaNombre = dr["EmpresaNombre"].ToString(),  // ← nuevo
                        ProductoID = Convert.ToInt32(dr["ProductoID"]),
                        PresentacionID = Convert.ToInt32(dr["PresentacionID"]),
                        Cantidad = Convert.ToInt32(dr["Cantidad"]),
                        FechaPedido = Convert.ToDateTime(dr["FechaPedido"]),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    });
                }
            }
            return lista;
        }

        public void AnularPedido(int id)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spAnularPedido", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoID", id);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<entPedido> ListarPedidosPorFecha(DateTime fecha)
        {
            List<entPedido> lista = new List<entPedido>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spListarPedidoPorFecha", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new entPedido
                            {
                                PedidoID = Convert.ToInt32(dr["PedidoID"]),
                                EmpresaID = Convert.ToInt32(dr["EmpresaID"]),
                                ProductoID = Convert.ToInt32(dr["ProductoID"]),
                                PresentacionID = Convert.ToInt32(dr["PresentacionID"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                FechaPedido = Convert.ToDateTime(dr["FechaPedido"]),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
