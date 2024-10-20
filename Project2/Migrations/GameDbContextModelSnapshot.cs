﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.Models;

#nullable disable

namespace Project2.Migrations
{
    [DbContext(typeof(GameDbContext))]
    partial class GameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project2.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MetaCritic")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Developer = "Ryu Ga Gotoku",
                            MetaCritic = 89,
                            Name = "Like A Dragon: Infinite Wealth",
                            ReleaseDate = "January 25th"
                        },
                        new
                        {
                            Id = 2,
                            Developer = "Atlus",
                            MetaCritic = 87,
                            Name = "Persona 3 Reload",
                            ReleaseDate = "Febuary 1st"
                        },
                        new
                        {
                            Id = 3,
                            Developer = "Square Enix Creative Buisiness Unit 1",
                            MetaCritic = 92,
                            Name = "Final Fantasy VII Rebirth",
                            ReleaseDate = "Febuary 29th"
                        },
                        new
                        {
                            Id = 4,
                            Developer = "Capcom",
                            MetaCritic = 92,
                            Name = "Dragons Dogma 2",
                            ReleaseDate = "March 21st"
                        },
                        new
                        {
                            Id = 5,
                            Developer = "Atlus",
                            MetaCritic = 94,
                            Name = "Metaphor: Refantazio",
                            ReleaseDate = "October 11"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}