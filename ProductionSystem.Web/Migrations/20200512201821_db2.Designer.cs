﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductionSystem.Web.Data;

namespace ProductionSystem.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200512201821_db2")]
    partial class db2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LineaId");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("LineaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Deshecho", b =>
                {
                    b.Property<int>("Id");

                    b.Property<decimal>("Cantidad");

                    b.Property<string>("Observaciones");

                    b.HasKey("Id");

                    b.ToTable("Deshechos");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Envase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad");

                    b.Property<bool>("Isplastic");

                    b.HasKey("Id");

                    b.ToTable("Envases");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Etiqueta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Altura");

                    b.Property<decimal>("Ancho");

                    b.Property<bool>("IsUsed");

                    b.Property<bool>("IsWaterProof");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<decimal>("PrecioUnitario");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Fase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Numero");

                    b.HasKey("Id");

                    b.ToTable("Fases");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Insumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsRawProduct");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<decimal>("Stock");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Insumos");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.InsumoUsado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CantidadUsada");

                    b.Property<int?>("InsumoId");

                    b.Property<int?>("ProduccionId");

                    b.HasKey("Id");

                    b.HasIndex("InsumoId");

                    b.HasIndex("ProduccionId");

                    b.ToTable("InsumoUsados");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.InventarioEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpresaId");

                    b.Property<int?>("ProductoRealId");

                    b.Property<int>("Stock");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("ProductoRealId");

                    b.ToTable("InventarioEmpresas");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Linea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Lineas");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpresaId");

                    b.Property<DateTime>("Fecha");

                    b.Property<decimal>("MontoTotal");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha");

                    b.Property<int?>("ProductoRealId");

                    b.Property<bool>("estado");

                    b.HasKey("Id");

                    b.HasIndex("ProductoRealId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CI")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Presentacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EnvaseId");

                    b.Property<int?>("EtiquetaId");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EnvaseId");

                    b.HasIndex("EtiquetaId");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Presentaciones");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Produccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpleadoProducciónId");

                    b.Property<int?>("FaseId");

                    b.Property<DateTime>("FechaProduccion");

                    b.Property<int?>("InsumoId");

                    b.Property<int?>("PedidoId");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoProducciónId");

                    b.HasIndex("FaseId");

                    b.HasIndex("InsumoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Producciones");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("PresentacionId");

                    b.Property<int?>("SaborId");

                    b.Property<int?>("TipoProductoId");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("PresentacionId");

                    b.HasIndex("SaborId");

                    b.HasIndex("TipoProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.ProductoPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Monto");

                    b.Property<int?>("PagoId");

                    b.Property<int?>("ProductoRealId");

                    b.Property<int>("UnidadesPagadas");

                    b.HasKey("Id");

                    b.HasIndex("PagoId");

                    b.HasIndex("ProductoRealId");

                    b.ToTable("ProductoPagos");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.ProductoReal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<int?>("ProductoId");

                    b.Property<int>("stock");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoReal");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InsumoId");

                    b.Property<int>("Porcentaje");

                    b.Property<int?>("ProductoRealId");

                    b.HasKey("Id");

                    b.HasIndex("InsumoId");

                    b.HasIndex("ProductoRealId");

                    b.ToTable("Recetas");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Resultado", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("Cantidad");

                    b.Property<string>("Observaciones");

                    b.HasKey("Id");

                    b.ToTable("Resultados");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Sabor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Sabores");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dirección");

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("Encargado");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.TipoProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("TipoProductos");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Cargo")
                        .IsRequired();

                    b.Property<int>("Ci");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<bool>("Disponible");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.EmpleadoProduccion", b =>
                {
                    b.HasBaseType("ProductionSystem.Web.Data.Entities.Persona");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Telefono");

                    b.ToTable("EmpleadoProduccion");

                    b.HasDiscriminator().HasValue("EmpleadoProduccion");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.EncargadoEmpresa", b =>
                {
                    b.HasBaseType("ProductionSystem.Web.Data.Entities.Persona");

                    b.Property<int>("IdEmpresa");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnName("EncargadoEmpresa_Telefono");

                    b.HasIndex("IdEmpresa")
                        .IsUnique()
                        .HasFilter("[IdEmpresa] IS NOT NULL");

                    b.ToTable("EncargadoEmpresa");

                    b.HasDiscriminator().HasValue("EncargadoEmpresa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ProductionSystem.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Categoria", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Linea")
                        .WithMany("Categorias")
                        .HasForeignKey("LineaId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Deshecho", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Produccion", "Produccion")
                        .WithOne("Deshecho")
                        .HasForeignKey("ProductionSystem.Web.Data.Entities.Deshecho", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.InsumoUsado", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Insumo", "Insumo")
                        .WithMany("InsumosUsados")
                        .HasForeignKey("InsumoId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.Produccion", "Produccion")
                        .WithMany("InsumosUsados")
                        .HasForeignKey("ProduccionId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.InventarioEmpresa", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Empresa", "Empresa")
                        .WithMany("InventarioEmpresas")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.ProductoReal", "ProductoReal")
                        .WithMany("InventarioEmpresas")
                        .HasForeignKey("ProductoRealId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Pago", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Empresa", "Empresa")
                        .WithMany("Pagos")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Pedido", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.ProductoReal", "ProductoReal")
                        .WithMany("Pedido")
                        .HasForeignKey("ProductoRealId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Presentacion", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Envase", "Envase")
                        .WithMany("Presentaciones")
                        .HasForeignKey("EnvaseId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.Etiqueta", "Etiqueta")
                        .WithMany("Presentacion")
                        .HasForeignKey("EtiquetaId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Produccion", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.EmpleadoProduccion", "EmpleadoProducción")
                        .WithMany("Producciones")
                        .HasForeignKey("EmpleadoProducciónId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.Fase", "Fase")
                        .WithMany("Producciones")
                        .HasForeignKey("FaseId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.Insumo")
                        .WithMany("Producciones")
                        .HasForeignKey("InsumoId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.Pedido", "Pedido")
                        .WithMany("Producciones")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Producto", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.Presentacion", "Presentacion")
                        .WithMany()
                        .HasForeignKey("PresentacionId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.Sabor", "Sabor")
                        .WithMany("Productos")
                        .HasForeignKey("SaborId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.TipoProducto", "TipoProducto")
                        .WithMany("Productos")
                        .HasForeignKey("TipoProductoId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.ProductoPago", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Pago", "Pago")
                        .WithMany("ProductoPago")
                        .HasForeignKey("PagoId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.ProductoReal", "ProductoReal")
                        .WithMany("ProductoPago")
                        .HasForeignKey("ProductoRealId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.ProductoReal", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Producto", "Producto")
                        .WithMany("ProductosReales")
                        .HasForeignKey("ProductoId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Receta", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Insumo", "Insumo")
                        .WithMany("Recetas")
                        .HasForeignKey("InsumoId");

                    b.HasOne("ProductionSystem.Web.Data.Entities.ProductoReal", "ProductoReal")
                        .WithMany("Recetas")
                        .HasForeignKey("ProductoRealId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Resultado", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Produccion", "Produccion")
                        .WithOne("Resultado")
                        .HasForeignKey("ProductionSystem.Web.Data.Entities.Resultado", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.Sucursal", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Empresa", "Empresa")
                        .WithMany("Sucursales")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("ProductionSystem.Web.Data.Entities.EncargadoEmpresa", b =>
                {
                    b.HasOne("ProductionSystem.Web.Data.Entities.Empresa", "Empresa")
                        .WithOne("EncargadoEmpresa")
                        .HasForeignKey("ProductionSystem.Web.Data.Entities.EncargadoEmpresa", "IdEmpresa")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
