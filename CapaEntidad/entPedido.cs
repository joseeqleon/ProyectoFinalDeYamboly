using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedido
    {
        public int PedidoID { get; set; }
        public int EmpresaID { get; set; }
        public string EmpresaNombre { get; set; }
        public int ProductoID { get; set; }
        public int PresentacionID { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool Estado { get; set; }
    }
}
