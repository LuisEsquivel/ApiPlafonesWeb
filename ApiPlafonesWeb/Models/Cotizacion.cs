using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class Cotizacion
    {
        public int CveCotizacionInt { get; set; }
        public string CveSucVar { get; set; }
        public int CveClieInt { get; set; }
        public string NomClieVar { get; set; }
        public int CveAgenteInt { get; set; }
        public decimal SubtotalDec { get; set; }
        public decimal IvaDec { get; set; }
        public decimal TotalDec { get; set; }
        public string FiFormapagoVar { get; set; }
        public DateTime FechaAltaDt { get; set; }
        public int EstatusInt { get; set; }
    }
}
