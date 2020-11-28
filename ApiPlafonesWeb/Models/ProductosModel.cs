using System;
using System.Collections.Generic;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class ProductosModel
    {
        public string CveProdVar { get; set; }
        public string NomProdVar { get; set; }
        public string DescProdVar { get; set; }
        public string CveClaseVar { get; set; }
        public string CveSubclaseVar { get; set; }
        public string CveSubgrupoVar { get; set; }
        public decimal PesoDec { get; set; }
        public string RutadefotoVar { get; set; }
        public bool EstatusBit { get; set; }
        public decimal? CostoPromedioDec { get; set; }
        public decimal? MetrosLinealesDec { get; set; }
        public decimal? MetrosCuadradosDec { get; set; }
        public string FichaTecnicaUrlVar { get; set; }
        public string AnchoVar { get; set; }
        public string AltoVar { get; set; }
        public string EspesorVar { get; set; }
        public string SugUsoVar { get; set; }
        public string UnidadMedidaVar { get; set; }
        public string MarcaVar { get; set; }
        public string ColorVar { get; set; }
        public string TexturaVar { get; set; }
        public string DescripcionImagenVar { get; set; }
        public int? OrdenCategoriaInt { get; set; }
        public int? OrdenSubcategoriaInt { get; set; }
        public bool? MostrarEnProductosDestacadosBit { get; set; }
        public string MetaTagProdVar { get; set; }
        public string UrlMetaTagProdVar { get; set; }
    }
}
