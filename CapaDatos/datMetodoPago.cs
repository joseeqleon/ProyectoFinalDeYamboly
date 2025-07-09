using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.datMetodoPago;

namespace CapaDatos
{
    public class datMetodoPago
    {
        public class datMetodoPago
        {
            private static readonly datMetodoPago _instancia = new datMetodoPago();
            public static datMetodoPago Instancia => _instancia;

            public List<entMetodoPago> ListarMetodoPago()
            {
                List<entMetodoPago> lista = new List<entMetodoPago>();
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM MetodoDePago WHERE Estado = 1", cn);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new entMetodoPago
                        {
                            MetodoPagoID = Convert.ToInt32(dr["MetodoPagoID"]),
                            Nombre = dr["Nombre"].ToString(),
                            Estado = Convert.ToBoolean(dr["Estado"])
                        });
                    }
                }
                return lista;
            }
        }
}
