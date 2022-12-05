﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recap.Data;

#nullable disable

namespace Recap.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221205102230_testingRemove")]
    partial class testingRemove
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Recap.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lineage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceLocation")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CharacterId");

                    b.HasIndex("PlaceLocation");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            FirstName = "Boromir",
                            LastName = "Son of Denethor",
                            Lineage = "Human"
                        },
                        new
                        {
                            CharacterId = 2,
                            FirstName = "Legolas",
                            LastName = "Greenleaf",
                            Lineage = "Elf"
                        },
                        new
                        {
                            CharacterId = 3,
                            FirstName = "Frodo",
                            LastName = "Baggins",
                            Lineage = "Halfling"
                        });
                });

            modelBuilder.Entity("Recap.Models.Place", b =>
                {
                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Location");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            Location = "Rivendell",
                            Description = "Elven otherworld, also known as Imladris in Sindarin. Important place in Middle-earth."
                        });
                });

            modelBuilder.Entity("Recap.Models.Character", b =>
                {
                    b.HasOne("Recap.Models.Place", "Place")
                        .WithMany("Characters")
                        .HasForeignKey("PlaceLocation")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Place");
                });

            modelBuilder.Entity("Recap.Models.Place", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}