﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_taller
{
    class NotaCreditoProveedor
    {
        private int NumeroProveedor;
        private int NumeroComprobante;
        private DateTime Fecha;
        private float Total;
        private List<LineaNotaCredito> ListaLineaNotaCredito;
    }
}
