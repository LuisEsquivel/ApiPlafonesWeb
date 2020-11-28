using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class MetaTagsPlafonesWebModel
    {
        public int IdInt { get; set; }
        public string MetatagVar { get; set; }
        public string DescripcionMetatagVar { get; set; }
        public DateTime FechaAltaDate { get; set; }
        public DateTime FechaModDatetime { get; set; }
        public bool? ActivoBit { get; set; }
    }
}
