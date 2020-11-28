using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class TblCapacitacione
    {
        public int CapacitacionId { get; set; }
        public string Descripcion { get; set; }
        public int ClasificacionId { get; set; }
        public string Titulo { get; set; }
        public string VideoUrl { get; set; }
        public string PdfUrl { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaAlta { get; set; }
        public int ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool EstaActivo { get; set; }
        public string Imagen { get; set; }
        public int Orden { get; set; }
    }
}
