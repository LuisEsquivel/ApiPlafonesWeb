using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiPlafonesWeb.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnitaImagene> AnitaImagenes { get; set; }
        public virtual DbSet<BorrarAltImg> BorrarAltImgs { get; set; }
        public virtual DbSet<BorrarMetatagsProdseva2> BorrarMetatagsProdseva2s { get; set; }
        public virtual DbSet<BorrarOrdenProdsEva> BorrarOrdenProdsEvas { get; set; }
        public virtual DbSet<BorrarSubirMetaTagsProducto> BorrarSubirMetaTagsProductos { get; set; }
        public virtual DbSet<BorrarmetaTagsProducto> BorrarmetaTagsProductos { get; set; }
        public virtual DbSet<ContactosModel> ContactosModels { get; set; }
        public virtual DbSet<Cotizacion> Cotizacions { get; set; }
        public virtual DbSet<MetaTagsPlafonesWebModel> MetaTagsPlafonesWebModels { get; set; }
        public virtual DbSet<ProductosModel> ProductosModels { get; set; }
        public virtual DbSet<RequieresInstalacionModel> RequieresInstalacionModels { get; set; }
        public virtual DbSet<Seguimiento> Seguimientos { get; set; }
        public virtual DbSet<Subir> Subirs { get; set; }
        public virtual DbSet<SubirDefinitivo> SubirDefinitivos { get; set; }
        public virtual DbSet<SucursalesModel> SucursalesModels { get; set; }
        public virtual DbSet<TblCapacitacione> TblCapacitaciones { get; set; }
        public virtual DbSet<TblClasificacione> TblClasificaciones { get; set; }
        public virtual DbSet<TblContacto> TblContactos { get; set; }
        public virtual DbSet<TblWhatsApp> TblWhatsApps { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TypeOfChangeModel> TypeOfChangeModels { get; set; }
        public virtual DbSet<UneteModel> UneteModels { get; set; }
        public virtual DbSet<WhatsAppModel> WhatsAppModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {            
                optionsBuilder.UseSqlServer("data source= 184.168.194.51; initial catalog=plafweb; user id=rtrevino; password=5@spwA22");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("rtrevino");

            modelBuilder.Entity<AnitaImagene>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AnitaImagenes", "dbo");

                entity.Property(e => e.CveProdVar)
                    .HasMaxLength(255)
                    .HasColumnName("CVE_PROD_VAR");

                entity.Property(e => e.DescProdVar)
                    .HasMaxLength(255)
                    .HasColumnName("DESC_PROD_VAR");

                entity.Property(e => e.NomProdVar)
                    .HasMaxLength(255)
                    .HasColumnName("NOM_PROD_VAR");

                entity.Property(e => e.Ruta1)
                    .HasMaxLength(255)
                    .HasColumnName("RUTA1");

                entity.Property(e => e.Ruta2)
                    .HasMaxLength(255)
                    .HasColumnName("RUTA2");
            });

            modelBuilder.Entity<BorrarAltImg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BorrarAltImgs", "dbo");

                entity.Property(e => e.Altimagen)
                    .HasMaxLength(255)
                    .HasColumnName("ALTIMAGEN");

                entity.Property(e => e.CveProdVar)
                    .HasMaxLength(255)
                    .HasColumnName("CVE_PROD_VAR");
            });

            modelBuilder.Entity<BorrarMetatagsProdseva2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BorrarMetatagsProdseva2", "dbo");

                entity.Property(e => e.Cve)
                    .HasMaxLength(255)
                    .HasColumnName("CVE");

                entity.Property(e => e.Descpagina)
                    .HasMaxLength(255)
                    .HasColumnName("DESCPAGINA");
            });

            modelBuilder.Entity<BorrarOrdenProdsEva>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BorrarOrdenProdsEva", "dbo");

                entity.Property(e => e.Cveprod)
                    .HasMaxLength(255)
                    .HasColumnName("CVEPROD");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");
            });

            modelBuilder.Entity<BorrarSubirMetaTagsProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BorrarSubirMetaTagsProducto", "dbo");

                entity.Property(e => e.CveProd)
                    .HasMaxLength(255)
                    .HasColumnName("CVE_PROD");

                entity.Property(e => e.Metatag)
                    .HasMaxLength(255)
                    .HasColumnName("METATAG");
            });

            modelBuilder.Entity<BorrarmetaTagsProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BorrarmetaTagsProductos", "dbo");

                entity.Property(e => e.Clave)
                    .HasMaxLength(255)
                    .HasColumnName("CLAVE");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<ContactosModel>(entity =>
            {
                entity.HasKey(e => e.CveContactoInt)
                    .HasName("PK_ContactosModelss");

                entity.ToTable("ContactosModels", "dbo");

                entity.Property(e => e.CveContactoInt).HasColumnName("CVE_CONTACTO_INT");

                entity.Property(e => e.CorreoVar)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_VAR");

                entity.Property(e => e.FechaAltaDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ALTA_DATE");

                entity.Property(e => e.MensajeVar)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("MENSAJE_VAR");

                entity.Property(e => e.NombreVar)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VAR");

                entity.Property(e => e.OrigenVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORIGEN_VAR");

                entity.Property(e => e.TelefonoVar)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO_VAR");
            });

            modelBuilder.Entity<Cotizacion>(entity =>
            {
                entity.HasKey(e => e.CveCotizacionInt);

                entity.ToTable("Cotizacion", "dbo");

                entity.Property(e => e.CveCotizacionInt).HasColumnName("cve_cotizacion_int");

                entity.Property(e => e.CveAgenteInt).HasColumnName("cve_agente_int");

                entity.Property(e => e.CveClieInt).HasColumnName("cve_clie_int");

                entity.Property(e => e.CveSucVar)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cve_suc_var");

                entity.Property(e => e.EstatusInt).HasColumnName("estatus_int");

                entity.Property(e => e.FechaAltaDt)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_alta_dt");

                entity.Property(e => e.FiFormapagoVar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fi_formapago_var");

                entity.Property(e => e.IvaDec)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("iva_dec");

                entity.Property(e => e.NomClieVar)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nom_clie_var");

                entity.Property(e => e.SubtotalDec)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal_dec");

                entity.Property(e => e.TotalDec)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_dec");
            });

            modelBuilder.Entity<MetaTagsPlafonesWebModel>(entity =>
            {
                entity.HasKey(e => e.IdInt)
                    .HasName("PK_dbo.MetaTagsPlafonesWebModel");

                entity.ToTable("MetaTagsPlafonesWebModels", "dbo");

                entity.Property(e => e.IdInt).HasColumnName("ID_INT");

                entity.Property(e => e.ActivoBit).HasColumnName("ACTIVO_BIT");

                entity.Property(e => e.DescripcionMetatagVar)
                    .HasColumnType("text")
                    .HasColumnName("DESCRIPCION_METATAG_VAR");

                entity.Property(e => e.FechaAltaDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ALTA_DATE");

                entity.Property(e => e.FechaModDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MOD_DATETIME");

                entity.Property(e => e.MetatagVar).HasColumnName("METATAG_VAR");
            });

            modelBuilder.Entity<ProductosModel>(entity =>
            {
                entity.HasKey(e => e.CveProdVar)
                    .HasName("PK_TBLPRODUCTOS");

                entity.ToTable("ProductosModels", "dbo");

                entity.Property(e => e.CveProdVar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CVE_PROD_VAR");

                entity.Property(e => e.AltoVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ALTO_VAR");

                entity.Property(e => e.AnchoVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ANCHO_VAR");

                entity.Property(e => e.ColorVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COLOR_VAR");

                entity.Property(e => e.CostoPromedioDec)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("COSTO_PROMEDIO_DEC");

                entity.Property(e => e.CveClaseVar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CVE_CLASE_VAR");

                entity.Property(e => e.CveSubclaseVar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CVE_SUBCLASE_VAR");

                entity.Property(e => e.CveSubgrupoVar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CVE_SUBGRUPO_VAR");

                entity.Property(e => e.DescProdVar)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("DESC_PROD_VAR");

                entity.Property(e => e.DescripcionImagenVar)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_IMAGEN_VAR");

                entity.Property(e => e.EspesorVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESPESOR_VAR");

                entity.Property(e => e.EstatusBit).HasColumnName("ESTATUS_BIT");

                entity.Property(e => e.FichaTecnicaUrlVar)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("FICHA_TECNICA_URL_VAR");

                entity.Property(e => e.MarcaVar)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MARCA_VAR");

                entity.Property(e => e.MetaTagProdVar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("META_TAG_PROD_VAR");

                entity.Property(e => e.MetrosCuadradosDec)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("METROS_CUADRADOS_DEC");

                entity.Property(e => e.MetrosLinealesDec)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("METROS_LINEALES_DEC");

                entity.Property(e => e.MostrarEnProductosDestacadosBit).HasColumnName("MOSTRAR_EN_PRODUCTOS_DESTACADOS_BIT");

                entity.Property(e => e.NomProdVar)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NOM_PROD_VAR");

                entity.Property(e => e.OrdenCategoriaInt).HasColumnName("ORDEN_CATEGORIA_INT");

                entity.Property(e => e.OrdenSubcategoriaInt).HasColumnName("ORDEN_SUBCATEGORIA_INT");

                entity.Property(e => e.PesoDec)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("PESO_DEC");

                entity.Property(e => e.RutadefotoVar)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RUTADEFOTO_VAR");

                entity.Property(e => e.SugUsoVar)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("SUG_USO_VAR");

                entity.Property(e => e.TexturaVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEXTURA_VAR");

                entity.Property(e => e.UnidadMedidaVar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_MEDIDA_VAR");

                entity.Property(e => e.UrlMetaTagProdVar)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URL_META_TAG_PROD_VAR");
            });

            modelBuilder.Entity<RequieresInstalacionModel>(entity =>
            {
                entity.HasKey(e => e.CveInstalacionInt)
                    .HasName("PK_IntalacionModels");

                entity.ToTable("RequieresInstalacionModels", "dbo");

                entity.Property(e => e.CveInstalacionInt).HasColumnName("CVE_INSTALACION_INT");

                entity.Property(e => e.CorreoVar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_VAR");

                entity.Property(e => e.DescripcionObraVar)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_OBRA_VAR");

                entity.Property(e => e.EstadoVar)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO_VAR");

                entity.Property(e => e.FechaAltaDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ALTA_DATE");

                entity.Property(e => e.MtsCuadradosInt).HasColumnName("MTS_CUADRADOS_INT");

                entity.Property(e => e.TelefonoVar)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO_VAR");
            });

            modelBuilder.Entity<Seguimiento>(entity =>
            {
                entity.HasKey(e => e.CveSeguimientoInt);

                entity.ToTable("Seguimiento", "dbo");

                entity.Property(e => e.CveSeguimientoInt).HasColumnName("cve_seguimiento_int");

                entity.Property(e => e.ContactoVar)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contacto_var");

                entity.Property(e => e.CorreoVar)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("correo_var");

                entity.Property(e => e.CveCotizacionInt).HasColumnName("cve_cotizacion_int");

                entity.Property(e => e.EstatusInt).HasColumnName("estatus_int");

                entity.Property(e => e.FechaAltaDt)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_alta_dt");

                entity.Property(e => e.FechaProxSegDt)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_prox_seg_dt");

                entity.Property(e => e.FechaSeguimientoDt)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_seguimiento_dt");

                entity.Property(e => e.ObservacionesVar)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_var");

                entity.Property(e => e.TelefonoVar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono_var");
            });

            modelBuilder.Entity<Subir>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUBIR", "dbo");

                entity.Property(e => e.Moneda).HasColumnName("MONEDA");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.Property(e => e.PrecioConIva).HasColumnName("PRECIO CON IVA");

                entity.Property(e => e.Preciousdconiva).HasColumnName("PRECIOUSDCONIVA");

                entity.Property(e => e.Prod)
                    .HasMaxLength(255)
                    .HasColumnName("PROD");
            });

            modelBuilder.Entity<SubirDefinitivo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubirDefinitivo", "dbo");

                entity.Property(e => e.AltoVar)
                    .HasMaxLength(255)
                    .HasColumnName("ALTO_VAR");

                entity.Property(e => e.AnchoVar)
                    .HasMaxLength(255)
                    .HasColumnName("ANCHO_VAR");

                entity.Property(e => e.ClaseVar)
                    .HasMaxLength(255)
                    .HasColumnName("CLASE_VAR");

                entity.Property(e => e.ColorVar)
                    .HasMaxLength(255)
                    .HasColumnName("COLOR_VAR");

                entity.Property(e => e.CostoPromedioDec).HasColumnName("COSTO_PROMEDIO_DEC");

                entity.Property(e => e.CveClaseVar)
                    .HasMaxLength(255)
                    .HasColumnName("CVE_CLASE_VAR");

                entity.Property(e => e.CveMarcaInt).HasColumnName("CVE_MARCA_INT");

                entity.Property(e => e.CveProdVar)
                    .HasMaxLength(255)
                    .HasColumnName("CVE_PROD_VAR");

                entity.Property(e => e.CveSubclaseVar)
                    .HasMaxLength(255)
                    .HasColumnName("CVE_SUBCLASE_VAR");

                entity.Property(e => e.CveSubgrupoVar)
                    .HasMaxLength(255)
                    .HasColumnName("CVE_SUBGRUPO_VAR");

                entity.Property(e => e.CveUniMedInt).HasColumnName("CVE_UNI_MED_INT");

                entity.Property(e => e.DescProdVar)
                    .HasMaxLength(255)
                    .HasColumnName("DESC_PROD_VAR");

                entity.Property(e => e.EspesorVar)
                    .HasMaxLength(255)
                    .HasColumnName("ESPESOR_VAR");

                entity.Property(e => e.EstatusBit)
                    .HasMaxLength(255)
                    .HasColumnName("ESTATUS_BIT");

                entity.Property(e => e.FichaTecnicaUrlVar)
                    .HasMaxLength(255)
                    .HasColumnName("FICHA_TECNICA_URL_VAR");

                entity.Property(e => e.MarcaVar)
                    .HasMaxLength(255)
                    .HasColumnName("MARCA_VAR");

                entity.Property(e => e.MetrosCuadradosDec).HasColumnName("METROS_CUADRADOS_DEC");

                entity.Property(e => e.MetrosLinealesDec).HasColumnName("METROS_LINEALES_DEC");

                entity.Property(e => e.NomProdVar)
                    .HasMaxLength(255)
                    .HasColumnName("NOM_PROD_VAR");

                entity.Property(e => e.PesoDec).HasColumnName("PESO_DEC");

                entity.Property(e => e.RutadefotoVar)
                    .HasMaxLength(255)
                    .HasColumnName("RUTADEFOTO_VAR");

                entity.Property(e => e.SubClaseVar)
                    .HasMaxLength(255)
                    .HasColumnName("SUB_CLASE_VAR");

                entity.Property(e => e.SubGrupoVar)
                    .HasMaxLength(255)
                    .HasColumnName("SUB_GRUPO_VAR");

                entity.Property(e => e.SugUsoVar)
                    .HasMaxLength(255)
                    .HasColumnName("SUG_USO_VAR");

                entity.Property(e => e.TexturaVar)
                    .HasMaxLength(255)
                    .HasColumnName("TEXTURA_VAR");

                entity.Property(e => e.UnidadMedidaVar)
                    .HasMaxLength(255)
                    .HasColumnName("UNIDAD_MEDIDA_VAR");
            });

            modelBuilder.Entity<SucursalesModel>(entity =>
            {
                entity.HasKey(e => e.CveSucursalInt)
                    .HasName("PK_dbo.Sucursales");

                entity.ToTable("SucursalesModels", "dbo");

                entity.Property(e => e.CveSucursalInt).HasColumnName("CVE_SUCURSAL_INT");

                entity.Property(e => e.ActivoBit).HasColumnName("ACTIVO_BIT");

                entity.Property(e => e.DireccionVar)
                    .HasMaxLength(300)
                    .HasColumnName("DIRECCION_VAR");

                entity.Property(e => e.LatitudVar)
                    .HasMaxLength(100)
                    .HasColumnName("LATITUD_VAR");

                entity.Property(e => e.LonguitudVar)
                    .HasMaxLength(100)
                    .HasColumnName("LONGUITUD_VAR");

                entity.Property(e => e.MapaVar).HasColumnName("MAPA_VAR");

                entity.Property(e => e.NombreSucursalVar)
                    .HasMaxLength(100)
                    .HasColumnName("NOMBRE_SUCURSAL_VAR");

                entity.Property(e => e.RutaImagenVar).HasColumnName("RUTA_IMAGEN_VAR");

                entity.Property(e => e.TelefonoVar)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TELEFONO_VAR");
            });

            modelBuilder.Entity<TblCapacitacione>(entity =>
            {
                entity.HasKey(e => e.CapacitacionId);

                entity.ToTable("tblCapacitaciones", "dbo");

                entity.Property(e => e.CapacitacionId).HasColumnName("CapacitacionID");

                entity.Property(e => e.ClasificacionId).HasColumnName("ClasificacionID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PdfUrl)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PdfURL");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.VideoUrl)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("VideoURL");
            });

            modelBuilder.Entity<TblClasificacione>(entity =>
            {
                entity.HasKey(e => e.ClasificacionId);

                entity.ToTable("tblClasificaciones", "dbo");

                entity.Property(e => e.ClasificacionId).HasColumnName("ClasificacionID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            });

            modelBuilder.Entity<TblContacto>(entity =>
            {
                entity.ToTable("TblContacto", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Colonia).HasMaxLength(100);

                entity.Property(e => e.Correo).HasMaxLength(100);

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Perfil).HasMaxLength(200);
            });

            modelBuilder.Entity<TblWhatsApp>(entity =>
            {
                entity.HasKey(e => e.CveInt);

                entity.ToTable("tblWhatsApp");

                entity.Property(e => e.CveInt).HasColumnName("CVE_INT");

                entity.Property(e => e.FechaDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DATETIME");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher", "dbo");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LongDescription)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MainDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDateTime)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeOfChangeModel>(entity =>
            {
                entity.HasKey(e => e.CveTipoCambio)
                    .HasName("PK_dbo.TypeOfChangeModel");

                entity.ToTable("TypeOfChangeModel", "dbo");

                entity.Property(e => e.CveTipoCambio).HasColumnName("CVE_TIPO_CAMBIO");

                entity.Property(e => e.DollarDec)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("DOLLAR_DEC");

                entity.Property(e => e.FechaEquipoDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_EQUIPO_DATETIME");

                entity.Property(e => e.FechaUniversalDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_UNIVERSAL_DATETIME");
            });

            modelBuilder.Entity<UneteModel>(entity =>
            {
                entity.HasKey(e => e.CveUneteInt)
                    .HasName("PK_dbo.UneteModels");

                entity.ToTable("UneteModels", "dbo");

                entity.Property(e => e.CveUneteInt).HasColumnName("CVE_UNETE_INT");

                entity.Property(e => e.ApellidoVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO_VAR");

                entity.Property(e => e.AreaInteresVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AREA_INTERES_VAR");

                entity.Property(e => e.CorreoVar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_VAR");

                entity.Property(e => e.DireccionVar)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_VAR");

                entity.Property(e => e.ExperienciaVar)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EXPERIENCIA_VAR");

                entity.Property(e => e.FechaAltaDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ALTA_DATE");

                entity.Property(e => e.NombreVar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_VAR");

                entity.Property(e => e.TelefonoVar)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO_VAR");
            });

            modelBuilder.Entity<WhatsAppModel>(entity =>
            {
                entity.HasKey(e => e.CveInt)
                    .HasName("PK_dbo.WhatsAppModels");

                entity.ToTable("WhatsAppModels", "dbo");

                entity.Property(e => e.CveInt).HasColumnName("CVE_INT");

                entity.Property(e => e.FechaDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DATETIME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
