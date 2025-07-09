using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datPresentacion
    {
        private static readonly datPresentacion _instancia = new datPresentacion();
        public static datPresentacion Instancia => _instancia;

        public List<entPresentacion> ListarPresentaciones(int productoID)
        {
            List<entPresentacion> lista = new List<entPresentacion>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spListarPresentacion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new entPresentacion
                            {
                                PresentacionID = Convert.ToInt32(dr["PresentacionID"]),
                                ProductoID = Convert.ToInt32(dr["ProductoID"]),
                                Presentacion = dr["Presentacion"].ToString(),
                                Precio = Convert.ToDecimal(dr["Precio"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool RegistrarPresentacion(entPresentacion p)
        {
            bool registrado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spRegistrarPresentacion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", p.ProductoID);
                    cmd.Parameters.AddWithValue("@Presentacion", p.Presentacion);
                    cmd.Parameters.AddWithValue("@Precio", p.Precio);
                    cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                    cn.Open();
                    registrado = cmd.ExecuteNonQuery() > 0;
                }
            }
            return registrado;
        }

        public bool EditarPresentacion(entPresentacion p)
        {
            bool editado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spEditarPresentacion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PresentacionID", p.PresentacionID);
                    cmd.Parameters.AddWithValue("@Presentacion", p.Presentacion);
                    cmd.Parameters.AddWithValue("@Precio", p.Precio);
                    cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                    cn.Open();
                    editado = cmd.ExecuteNonQuery() > 0;
                }
            }
            return editado;
        }
        public bool EliminarPresentacion(int presentacionID)
        {
            bool eliminado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spEliminarPresentacion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PresentacionID", presentacionID);
                    cn.Open();
                    eliminado = cmd.ExecuteNonQuery() > 0;
                }
            }
            return eliminado;
        }
        public List<entPresentacion> ListarPresentacionesGlobal()
        {
            List<entPresentacion> lista = new List<entPresentacion>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spListarPresentacionesGlobal", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new entPresentacion
                            {
                                PresentacionID = Convert.ToInt32(dr["PresentacionID"]),
                                ProductoID = Convert.ToInt32(dr["ProductoID"]),
                                Presentacion = dr["Presentacion"].ToString(),
                                Precio = Convert.ToDecimal(dr["Precio"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
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
