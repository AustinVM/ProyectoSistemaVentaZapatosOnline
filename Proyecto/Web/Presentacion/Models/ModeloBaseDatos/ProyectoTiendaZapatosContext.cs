using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class ProyectoTiendaZapatosContext : DbContext
{
    public ProyectoTiendaZapatosContext()
    {
    }

    public ProyectoTiendaZapatosContext(DbContextOptions<ProyectoTiendaZapatosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriaCliente> CategoriaClientes { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Coleccion> Coleccions { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DetallesFactura> DetallesFacturas { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Iva> Ivas { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoTalla> ProductoTallas { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Talla> Tallas { get; set; }

    public virtual DbSet<TipoCalzado> TipoCalzados { get; set; }

    public virtual DbSet<TipoCliente> TipoClientes { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost; database=ProyectoTiendaZapatos; user=sa; password=holamundo; TrustServerCertificate=True; Connect Timeout=150");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__categori__3213E83F8DB89FAA");

            entity.ToTable("categoriaCliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Descuento).HasColumnName("descuento");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.NumId).HasName("PK__cliente__AF858512A12931FA");

            entity.ToTable("cliente");

            entity.HasIndex(e => e.CorreoElectronico, "UQ__cliente__ED1E3B6ED4C7E8A3").IsUnique();

            entity.Property(e => e.NumId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contrasenia");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correoElectronico");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FchNac)
                .HasColumnType("date")
                .HasColumnName("fchNac");
            entity.Property(e => e.IdCategoria).HasColumnName("id_Categoria");
            entity.Property(e => e.IdMunicipio).HasColumnName("id_Municipio");
            entity.Property(e => e.IdTipoCliente).HasColumnName("id_TipoCliente");
            entity.Property(e => e.IdTipoDocumento).HasColumnName("id_TipoDocumento");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cliente__id_Cate__75A278F5");

            entity.HasOne(d => d.IdMunicipioNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdMunicipio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cliente__id_Muni__74AE54BC");

            entity.HasOne(d => d.IdTipoClienteNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdTipoCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cliente__id_Tipo__73BA3083");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdTipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cliente__id_Tipo__72C60C4A");
        });

        modelBuilder.Entity<Coleccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__coleccio__3213E83F7D85D20A");

            entity.ToTable("coleccion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Epoca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("epoca");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__color__3214EC07CBDDEAD8");

            entity.ToTable("color");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__departam__3214EC074669ECB1");

            entity.ToTable("departamento");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DetallesFactura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__detalles__3213E83FC620DFD5");

            entity.ToTable("detallesFactura");

            entity.HasIndex(e => e.IdPedido, "UQ__detalles__4AC0D5541DF4ACE7").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdIva).HasColumnName("id_Iva");
            entity.Property(e => e.IdPedido).HasColumnName("id_Pedido");
            entity.Property(e => e.IdTipoPago).HasColumnName("id_TipoPago");
            entity.Property(e => e.Subtotal).HasColumnName("subtotal");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.IdIvaNavigation).WithMany(p => p.DetallesFacturas)
                .HasForeignKey(d => d.IdIva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detallesF__id_Iv__25518C17");

            entity.HasOne(d => d.IdPedidoNavigation).WithOne(p => p.DetallesFactura)
                .HasForeignKey<DetallesFactura>(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detallesF__id_Pe__2180FB33");

            entity.HasOne(d => d.IdTipoPagoNavigation).WithMany(p => p.DetallesFacturas)
                .HasForeignKey(d => d.IdTipoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detallesF__id_Ti__236943A5");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => new { e.NumIdCliente, e.Nit }).HasName("PK__empresa__B6F88A283ABBFF69");

            entity.ToTable("empresa");

            entity.HasIndex(e => e.NumIdCliente, "UQ__empresa__9A856615001335F6").IsUnique();

            entity.HasIndex(e => e.Nit, "UQ__empresa__C7DEC3C2AC4D9498").IsUnique();

            entity.Property(e => e.NumIdCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numID_Cliente");
            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.DirBodega)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dirBodega");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.NombreEmpresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreEmpresa");

            entity.HasOne(d => d.NumIdClienteNavigation).WithOne(p => p.Empresa)
                .HasForeignKey<Empresa>(d => d.NumIdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__empresa__numID_C__7C4F7684");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__factura__3213E83F5F6EF8B0");

            entity.ToTable("factura");

            entity.HasIndex(e => e.IdDetallesFactura, "UQ__factura__870219E25B786EE4").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FchExpedicion)
                .HasColumnType("datetime")
                .HasColumnName("fchExpedicion");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id_Cliente");
            entity.Property(e => e.IdDetallesFactura).HasColumnName("id_DetallesFactura");
            entity.Property(e => e.IdMunicipio).HasColumnName("id_Municipio");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__factura__id_Clie__3B40CD36");

            entity.HasOne(d => d.IdDetallesFacturaNavigation).WithOne(p => p.Factura)
                .HasForeignKey<Factura>(d => d.IdDetallesFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__factura__id_Deta__3D2915A8");

            entity.HasOne(d => d.IdMunicipioNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdMunicipio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__factura__id_Muni__3F115E1A");
        });

        modelBuilder.Entity<Iva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__iva__3214EC07BB536AAC");

            entity.ToTable("iva");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__material__3214EC07A513ECA3");

            entity.ToTable("material");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__municipi__3213E83FF1EF06DB");

            entity.ToTable("municipio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.IdDepartamento).HasColumnName("id_Departamento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.IdDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__municipio__id_De__5441852A");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pedido__3213E83F209C86AA");

            entity.ToTable("pedido");

            entity.HasIndex(e => e.IdProductoTalla, "UQ__pedido__DCA960A4D6C59B40").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CantidadPedido).HasColumnName("cantidadPedido");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id_Cliente");
            entity.Property(e => e.IdProductoTalla).HasColumnName("id_Producto_talla");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pedido__id_Clien__17F790F9");

            entity.HasOne(d => d.IdProductoTallaNavigation).WithOne(p => p.Pedido)
                .HasForeignKey<Pedido>(d => d.IdProductoTalla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pedido__id_Produ__19DFD96B");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__producto__3213E83F9860A011");

            entity.ToTable("producto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.IdColeccion).HasColumnName("id_Coleccion");
            entity.Property(e => e.IdColor).HasColumnName("id_Color");
            entity.Property(e => e.IdMaterial).HasColumnName("id_Material");
            entity.Property(e => e.IdTipoCalzado).HasColumnName("id_TipoCalzado");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreProducto");

            entity.HasOne(d => d.IdColeccionNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdColeccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__producto__id_Col__04E4BC85");

            entity.HasOne(d => d.IdColorNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdColor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__producto__id_Col__02FC7413");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__producto__id_Mat__06CD04F7");

            entity.HasOne(d => d.IdTipoCalzadoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdTipoCalzado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__producto__id_Tip__08B54D69");
        });

        modelBuilder.Entity<ProductoTalla>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__producto__3213E83F8E1D7BA5");

            entity.ToTable("producto_talla");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.IdProducto).HasColumnName("id_Producto");
            entity.Property(e => e.IdTalla).HasColumnName("id_Talla");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.ValUnitario).HasColumnName("valUnitario");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductoTallas)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__producto___id_Pr__0E6E26BF");

            entity.HasOne(d => d.IdTallaNavigation).WithMany(p => p.ProductoTallas)
                .HasForeignKey(d => d.IdTalla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__producto___id_Ta__0F624AF8");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3214EC070B753782");

            entity.ToTable("Rol");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Talla>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tallas__3214EC07BB65DE96");

            entity.ToTable("tallas");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCalzado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipoCalz__3214EC07B93C512A");

            entity.ToTable("tipoCalzado");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipoClie__3214EC07E6B94834");

            entity.ToTable("tipoCliente");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoDocu__3214EC0712F04B31");

            entity.ToTable("TipoDocumento");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipoPago__3214EC075FFB7271");

            entity.ToTable("tipoPago");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F909B7B30");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.Usuario1, "UQ__Usuario__E3237CF7B792BE55").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IdRol).HasColumnName("Id_Rol");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__Id_Rol__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
