using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datEmpresa
    {
        private static readonly datEmpresa _instancia = new datEmpresa();
        public static datEmpresa Instancia => _instancia;

        public List<entEmpresa> ListarEmpresa()
        {
            List<entEmpresa> lista = new List<entEmpresa>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("spListarEmpresa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpresa emp = new entEmpresa
                    {
                        EmpresaID = Convert.ToInt32(dr["EmpresaID"]),
                        Nombre = dr["Nombre"].ToString(),
                        RUC = dr["RUC"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"]),
                        Ubigeo = new entUbigeo
                        {
                            UbigeoID = dr["UbigeoID"].ToString(),
                            Departamento = dr["Departamento"].ToString(),
                            Provincia = dr["Provincia"].ToString(),
                            Distrito = dr["Distrito"].ToString()
                        }
                    };
                    lista.Add(emp);
                }
            }
            return lista;
        }

        public bool RegistrarEmpresa(entEmpresa e)
        {
            bool registrar = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spRegistrarEmpresa", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", e.Nombre);
                    cmd.Parameters.AddWithValue("@RUC", e.RUC);
                    cmd.Parameters.AddWithValue("@UbigeoID", e.Ubigeo.UbigeoID);  // ✅ CORREGIDO
                    cn.Open();
                    registrar = cmd.ExecuteNonQuery() > 0;
                }
            }
            return registrar;
        }

        public bool EditarEmpresa(entEmpresa e)
        {
            bool editado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spEditarEmpresa", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpresaID", e.EmpresaID);
                    cmd.Parameters.AddWithValue("@Nombre", e.Nombre);
                    cmd.Parameters.AddWithValue("@RUC", e.RUC);
                    cmd.Parameters.AddWithValue("@UbigeoID", e.Ubigeo.UbigeoID);  // ✅ CORREGIDO
                    cn.Open();
                    editado = cmd.ExecuteNonQuery() > 0;
                }
            }
            return editado;
        }

        public bool EliminarEmpresa(int empresaID)
        {
            bool eliminado = false;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("spEliminarEmpresa", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpresaID", empresaID);
                    cn.Open();
                    eliminado = cmd.ExecuteNonQuery() > 0;
                }
            }
            return eliminado;
        }
        public bool ExisteRUC(string ruc)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Empresa WHERE RUC = @RUC AND Estado = 1", cn);
                cmd.Parameters.AddWithValue("@RUC", ruc);
                cn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
