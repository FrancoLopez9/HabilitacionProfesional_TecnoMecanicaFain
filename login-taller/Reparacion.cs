using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_taller
{
    class Reparacion
    {
        private int NumeroCliente;
        private int NumeroVehiculo;
        private int Numero;
        private DateTime Fecha;
        private float CostoManoObra;
        private int Cantidad;
        private float SubTotal;
        private float Total;
        private List<LineaReparacion> ListaLineaReparacion;
    }
}
