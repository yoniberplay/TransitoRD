﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransitoRD.Infrastucture.Persistence.Contexts;

#nullable disable

namespace TransitoRD.Infrastucture.Persistence.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231204225432_migracionInical")]
    partial class migracionInical
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.Agentes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UltimaModificaio")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificaionPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estatus")
                        .HasColumnType("bit");

                    b.Property<int>("multasId")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agentes", (string)null);
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.Licencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha_Nacimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UltimaModificaio")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificaionPor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Licencia", (string)null);
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.Multas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgenteId")
                        .HasColumnType("int");

                    b.Property<string>("Audio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula_infractor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoMulta")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitud")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LicenciaId")
                        .HasColumnType("int");

                    b.Property<string>("Longitud")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa_Vehiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UltimaModificaio")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificaionPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("vehiculosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgenteId");

                    b.HasIndex("CodigoMulta");

                    b.HasIndex("LicenciaId");

                    b.HasIndex("vehiculosId");

                    b.ToTable("Multas", (string)null);
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.MultasTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CodigoMulta")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UltimaModificaio")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificaionPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MultasTipo", (string)null);
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.Vehiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cedula_Propietario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chasis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion_Propietario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Propietario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pasajeros")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UltimaModificaio")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificaionPor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos", (string)null);
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.Multas", b =>
                {
                    b.HasOne("TransitoRD.Core.Domain.Entities.Agentes", "Agente")
                        .WithMany("multas")
                        .HasForeignKey("AgenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransitoRD.Core.Domain.Entities.MultasTipo", "MultasTipo")
                        .WithMany("multas")
                        .HasForeignKey("CodigoMulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransitoRD.Core.Domain.Entities.Licencia", "Licencia")
                        .WithMany("multas")
                        .HasForeignKey("LicenciaId");

                    b.HasOne("TransitoRD.Core.Domain.Entities.Vehiculos", "vehiculos")
                        .WithMany("multas")
                        .HasForeignKey("vehiculosId");

                    b.Navigation("Agente");

                    b.Navigation("Licencia");

                    b.Navigation("MultasTipo");

                    b.Navigation("vehiculos");
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.Agentes", b =>
                {
                    b.Navigation("multas");
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.Licencia", b =>
                {
                    b.Navigation("multas");
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.MultasTipo", b =>
                {
                    b.Navigation("multas");
                });

            modelBuilder.Entity("TransitoRD.Core.Domain.Entities.Vehiculos", b =>
                {
                    b.Navigation("multas");
                });
#pragma warning restore 612, 618
        }
    }
}