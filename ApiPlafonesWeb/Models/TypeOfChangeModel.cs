using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class TypeOfChangeModel
    {
        public int CveTipoCambio { get; set; }
        public DateTime FechaEquipoDatetime { get; set; }
        public DateTime? FechaUniversalDatetime { get; set; }
        public decimal DollarDec { get; set; }
    }
}
