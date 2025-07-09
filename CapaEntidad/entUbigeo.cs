using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUbigeo
    {
        public string UbigeoID { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public override string ToString()
        {
            return $"{Departamento} / {Provincia} / {Distrito}";
        }
    }
}
