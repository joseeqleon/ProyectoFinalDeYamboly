using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datProducto
    {
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia => _instancia;

        public List<entProducto> ListarProducto()
        {
            List<entProducto> lista = new List<entProducto>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spListarProducto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new entProducto
                            {
                                ProductoID = Convert.ToInt32(dr["ProductoID"]),
                                Producto = dr["Producto"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool RegistrarProducto(entProducto p)
        {
            bool registrado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spRegistrarProducto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Producto", p.Producto);
                    cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                    cn.Open();
                    registrado = cmd.ExecuteNonQuery() > 0;
                }
            }
            return registrado;
        }

        public bool EditarProducto(entProducto p)
        {
            bool editado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spEditarProducto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", p.ProductoID);
                    cmd.Parameters.AddWithValue("@Producto", p.Producto);
                    cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                    cn.Open();
                    editado = cmd.ExecuteNonQuery() > 0;
                }
            }
            return editado;
        }
        public bool EliminarProducto(int productoID)
        {
            bool eliminado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spEliminarProducto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cn.Open();
                    eliminado = cmd.ExecuteNonQuery() > 0;
                }
            }
            return eliminado;
        }
    }
}
