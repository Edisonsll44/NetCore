﻿// <auto-generated />
using System;
using ClinicMedicalAppointments.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClinicMedicalAppointments.Infraestructure.Migrations
{
    [DbContext(typeof(ClinicaVeterinariaDbContext))]
    [Migration("20250307034128_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.ConsultaMedica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Desparasitacion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<string>("EstadoReproductivo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaDesparasitacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("HistoriaClinicaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("HistoriaId")
                        .HasColumnType("uuid");

                    b.Property<string>("MotivoConsulta")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Procedencia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pronostico")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RecetaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecetaMedicaId")
                        .HasColumnType("uuid");

                    b.Property<string>("Vacunas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("RecetaMedicaId");

                    b.ToTable("consulta_medica", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Especialidad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TipoEspecialidad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("especialidad", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.HistoriaClinica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaAdmision")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("MascotaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MedicoVeterinarioId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("MedicoVeterinarioId");

                    b.ToTable("historia_clinica", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Mascota", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PropietarioId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RazaId")
                        .HasColumnType("uuid");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PropietarioId");

                    b.HasIndex("RazaId");

                    b.ToTable("mascota", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.MedicoVeterinario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("EspecialidadId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("medico_veterinario", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Propietario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ApellidoPropietario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NombrePropietario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("propietario", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Raza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("raza", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.RecetaMedica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Prescripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("receta_medica", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Rol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Estado")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RolId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.ConsultaMedica", b =>
                {
                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.HistoriaClinica", "HistoriaClinica")
                        .WithMany("ConsultasMedicas")
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.RecetaMedica", "RecetaMedica")
                        .WithMany("ConsultasMedicas")
                        .HasForeignKey("RecetaMedicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HistoriaClinica");

                    b.Navigation("RecetaMedica");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.HistoriaClinica", b =>
                {
                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.Mascota", "Mascota")
                        .WithMany("HistoriasClinicas")
                        .HasForeignKey("MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.MedicoVeterinario", "MedicoVeterinario")
                        .WithMany("HistoriasClinicas")
                        .HasForeignKey("MedicoVeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");

                    b.Navigation("MedicoVeterinario");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Mascota", b =>
                {
                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.Propietario", "Propietario")
                        .WithMany("Mascotas")
                        .HasForeignKey("PropietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.Raza", "Raza")
                        .WithMany("Mascotas")
                        .HasForeignKey("RazaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propietario");

                    b.Navigation("Raza");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.MedicoVeterinario", b =>
                {
                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.Especialidad", "Especialidad")
                        .WithMany("MedicosVeterinarios")
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.Usuario", "Usuario")
                        .WithMany("MedicosVeterinarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidad");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Usuario", b =>
                {
                    b.HasOne("ClinicMedicalAppointments.Entities.Entities.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Especialidad", b =>
                {
                    b.Navigation("MedicosVeterinarios");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.HistoriaClinica", b =>
                {
                    b.Navigation("ConsultasMedicas");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Mascota", b =>
                {
                    b.Navigation("HistoriasClinicas");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.MedicoVeterinario", b =>
                {
                    b.Navigation("HistoriasClinicas");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Propietario", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Raza", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.RecetaMedica", b =>
                {
                    b.Navigation("ConsultasMedicas");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ClinicMedicalAppointments.Entities.Entities.Usuario", b =>
                {
                    b.Navigation("MedicosVeterinarios");
                });
#pragma warning restore 612, 618
        }
    }
}
