using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class RequieresInstalacionModel
    {
        public int CveInstalacionInt { get; set; }
        public string DescripcionObraVar { get; set; }
        public int MtsCuadradosInt { get; set; }
        public string EstadoVar { get; set; }
        public string TelefonoVar { get; set; }
        public string CorreoVar { get; set; }
        public DateTime FechaAltaDate { get; set; }
    }
}
