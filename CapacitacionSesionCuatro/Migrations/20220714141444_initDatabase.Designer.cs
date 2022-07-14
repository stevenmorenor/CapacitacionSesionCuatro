﻿// <auto-generated />
using System;
using CapacitacionSesionCuatro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CapacitacionSesionCuatro.Migrations
{
    [DbContext(typeof(PlayerContext))]
    [Migration("20220714141444_initDatabase")]
    partial class initDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CapacitacionSesionCuatro.Coach", b =>
                {
                    b.Property<int>("Id_Coach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId_Player")
                        .HasColumnType("int");

                    b.Property<int>("Player_Id")
                        .HasColumnType("int");

                    b.HasKey("Id_Coach");

                    b.HasIndex("PlayerId_Player");

                    b.ToTable("Coachs");
                });

            modelBuilder.Entity("CapacitacionSesionCuatro.Player", b =>
                {
                    b.Property<int>("Id_Player")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Player");

                    b.ToTable("players");
                });

            modelBuilder.Entity("CapacitacionSesionCuatro.Coach", b =>
                {
                    b.HasOne("CapacitacionSesionCuatro.Player", "Player")
                        .WithMany("Coaches")
                        .HasForeignKey("PlayerId_Player");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("CapacitacionSesionCuatro.Player", b =>
                {
                    b.Navigation("Coaches");
                });
#pragma warning restore 612, 618
        }
    }
}
