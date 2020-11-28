using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class ContactosModel
    {
        public int CveContactoInt { get; set; }
        public string NombreVar { get; set; }
        public string TelefonoVar { get; set; }
        public string CorreoVar { get; set; }
        public string MensajeVar { get; set; }
        public DateTime? FechaAltaDate { get; set; }
        public string OrigenVar { get; set; }
    }
}
