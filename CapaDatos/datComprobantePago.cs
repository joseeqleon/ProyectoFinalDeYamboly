using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datComprobantePago
    {
        private static readonly datComprobantePago _instancia = new datComprobantePago();
        public static datComprobantePago Instancia => _instancia;

        public bool RegistrarComprobante(entComprobantePago c)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("spRegistrarPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PedidoID", c.PedidoID);
                cmd.Parameters.AddWithValue("@MetodoPagoID", c.MetodoPagoID);
                cmd.Parameters.AddWithValue("@FechaEntrega", c.FechaEntrega);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ListarComprobantes()
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("spListarPago", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool ExistePagoParaPedido(int pedidoID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("spExistePagoPorPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PedidoID", pedidoID);
                cn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
