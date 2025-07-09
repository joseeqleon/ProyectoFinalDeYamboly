using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datUbigeo
    {
        private static readonly datUbigeo _instancia = new datUbigeo();
        public static datUbigeo Instancia => _instancia;

        public List<entUbigeo> ListarUbigeo()
        {
            List<entUbigeo> lista = new List<entUbigeo>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ubigeo", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entUbigeo
                    {
                        UbigeoID = dr["UbigeoID"].ToString(),
                        Departamento = dr["Departamento"].ToString(),
                        Provincia = dr["Provincia"].ToString(),
                        Distrito = dr["Distrito"].ToString()
                    });
                }
            }
            return lista;
        }

        public entUbigeo ObtenerUbigeoPorID(string id)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ubigeo WHERE UbigeoID = @id", cn);
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return new entUbigeo
                    {
                        UbigeoID = dr["UbigeoID"].ToString(),
                        Departamento = dr["Departamento"].ToString(),
                        Provincia = dr["Provincia"].ToString(),
                        Distrito = dr["Distrito"].ToString()
                    };
                }
            }
            return null;
        }
    }
}
