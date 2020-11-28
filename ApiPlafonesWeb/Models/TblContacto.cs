using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class TblContacto
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Perfil { get; set; }
        public string Correo { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
    }
}
