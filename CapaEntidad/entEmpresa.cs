using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpresa
    {
        public int EmpresaID { get; set; }
        public string Nombre { get; set; }
        public string RUC { get; set; }
        public entUbigeo Ubigeo { get; set; }  // objeto relacionado
        public bool Estado { get; set; }
    }
}
