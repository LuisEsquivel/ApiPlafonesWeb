using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class Subir
    {
        public string Prod { get; set; }
        public double? Moneda { get; set; }
        public double? Precio { get; set; }
        public double? PrecioConIva { get; set; }
        public double? Preciousdconiva { get; set; }
    }
}
