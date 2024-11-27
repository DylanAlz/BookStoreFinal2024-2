﻿// <auto-generated />
using System;
using ApilibrosFinal2024_2.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApilibrosFinal2024_2.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20241127035827_MyfirstMigration")]
    partial class MyfirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApilibrosFinal2024_2.Dal.Entities.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LibroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Nombre_cat")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("descripcion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibroId");

                    b.HasIndex("Nombre_cat", "LibroId")
                        .IsUnique();

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ApilibrosFinal2024_2.Dal.Entities.Libro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("titulo")
                        .IsUnique();

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("ApilibrosFinal2024_2.Dal.Entities.Categoria", b =>
                {
                    b.HasOne("ApilibrosFinal2024_2.Dal.Entities.Libro", "Libro")
                        .WithMany("categorias")
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("ApilibrosFinal2024_2.Dal.Entities.Libro", b =>
                {
                    b.Navigation("categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
