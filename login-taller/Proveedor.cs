using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_taller
{
    public class Proveedor
    {
        public int Numero { get; set; }
        public string CUIT { get; set; }
        public string RazonSocial { get; set; }
        public int Telefono { get; set; }
        public string Domicilio { get; set; }
        public int CodigoPostal { get; set; }
        public string Email { get; set; }
    }
}
