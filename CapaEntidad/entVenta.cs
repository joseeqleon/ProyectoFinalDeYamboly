using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public int VentaID { get; set; }
        public int PedidoID { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool Estado { get; set; }
    }
}
