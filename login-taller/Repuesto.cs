using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_taller
{
    public class Repuesto
    {
        public int NumeroProveedor { get; set; }
        public int Numero { get; set; }
        public int CodigoProveedor { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float PrecioCosto { get; set; }
        public int Ganancia { get; set; }
        public float PrecioLista { get; set; }
        public int Stock { get; set; }

    }
}
