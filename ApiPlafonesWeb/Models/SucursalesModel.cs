using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class SucursalesModel
    {
        public int CveSucursalInt { get; set; }
        public string NombreSucursalVar { get; set; }
        public string DireccionVar { get; set; }
        public string TelefonoVar { get; set; }
        public string LatitudVar { get; set; }
        public string LonguitudVar { get; set; }
        public string MapaVar { get; set; }
        public string RutaImagenVar { get; set; }
        public bool ActivoBit { get; set; }
    }
}
