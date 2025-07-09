using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entComprobantePago
    {
        public int ComprobanteID { get; set; }
        public int PedidoID { get; set; }
        public int MetodoPagoID { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool Estado { get; set; }
    }
}
