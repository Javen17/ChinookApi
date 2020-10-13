﻿// <auto-generated />
using System;
using EmployeesBusinessModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chinook.BusinessModel.Migrations
{
    [DbContext(typeof(ChinookContext))]
    [Migration("20201005194008_All-Models-Added")]
    partial class AllModelsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chinook.BusinessModel.Models.Album", b =>
                {
                    b.Property<long>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AlbumId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("AlbumId1");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Chinook.BusinessModel.Models.Artist", b =>
                {
                    b.Property<long>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AlbumId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Chinook.BusinessModel.Models.Genre", b =>
                {
                    b.Property<long>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Chinook.BusinessModel.Models.Album", b =>
                {
                    b.HasOne("Chinook.BusinessModel.Models.Album", null)
                        .WithMany("Albums")
                        .HasForeignKey("AlbumId1");
                });

            modelBuilder.Entity("Chinook.BusinessModel.Models.Artist", b =>
                {
                    b.HasOne("Chinook.BusinessModel.Models.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
