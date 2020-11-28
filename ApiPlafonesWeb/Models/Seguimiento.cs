using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class Seguimiento
    {
        public int CveSeguimientoInt { get; set; }
        public int CveCotizacionInt { get; set; }
        public string ContactoVar { get; set; }
        public string CorreoVar { get; set; }
        public string TelefonoVar { get; set; }
        public string ObservacionesVar { get; set; }
        public int EstatusInt { get; set; }
        public DateTime FechaProxSegDt { get; set; }
        public DateTime FechaSeguimientoDt { get; set; }
        public DateTime FechaAltaDt { get; set; }
    }
}
