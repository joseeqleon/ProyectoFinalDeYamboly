using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int ProductoID { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
