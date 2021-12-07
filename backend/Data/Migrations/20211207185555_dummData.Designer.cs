﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20211207185555_dummData")]
    partial class dummData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearReleased")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("44d65caa-c981-4866-ba71-9f305fd9ca6b"),
                            Author = "J.Guillou",
                            Rating = 5,
                            Title = "Ondskan",
                            YearReleased = new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ceacba30-8aab-4bc6-9580-5b646b740ea3"),
                            Author = "V. Moberg",
                            Rating = 5,
                            Title = "Utvandrarna",
                            YearReleased = new DateTime(1949, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("eb34d06e-ac23-4f92-ab13-1168d1b873bf"),
                            Author = "Daniel Defoe",
                            Rating = 4,
                            Title = "Robinson Crusoe",
                            YearReleased = new DateTime(1719, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e29531bf-de5f-4dff-8bf2-db2962341826"),
                            Author = "Marcel Proust",
                            Rating = 4,
                            Title = " In Search of Lost Time",
                            YearReleased = new DateTime(1913, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f7750f1a-3ae5-419b-a320-8ff327650d91"),
                            Author = "Miguel de Cervantes",
                            Rating = 5,
                            Title = "Don Quixote",
                            YearReleased = new DateTime(1605, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("fdfe2eeb-b63b-4b47-a31f-b0bfc1670fd4"),
                            Author = "Herman Melville",
                            Rating = 5,
                            Title = "Moby Dick",
                            YearReleased = new DateTime(1851, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
