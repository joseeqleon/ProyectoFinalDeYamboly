using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPresentacion
    {
        public int PresentacionID { get; set; }
        public int ProductoID { get; set; }
        public string Presentacion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public bool Estado { get; set; }
    }
}
