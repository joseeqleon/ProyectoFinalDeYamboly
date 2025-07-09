using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia => _instancia;

        public SqlConnection Conectar()
        {
            return new SqlConnection("Data Source=DESKTOP-EFKM9R6;Initial Catalog=PruebaHeladeriaBaseDatosYamboly;Integrated Security=true");
        }
    }
}
