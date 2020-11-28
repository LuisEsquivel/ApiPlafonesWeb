using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class TblClasificacione
    {
        public int ClasificacionId { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaAlta { get; set; }
        public int ModificadoPor { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool EstaActivo { get; set; }
    }
}
