﻿// <auto-generated />
using System;
using Employees.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Employees.API.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Employees.API.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 12, 2, 16, 11, 55, 974, DateTimeKind.Local).AddTicks(7495),
                            Description = "Microsoft company",
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 12, 2, 16, 11, 55, 974, DateTimeKind.Local).AddTicks(7506),
                            Description = "Apple company",
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 12, 2, 16, 11, 55, 974, DateTimeKind.Local).AddTicks(7507),
                            Description = "Intel company",
                            Name = "Intel"
                        });
                });

            modelBuilder.Entity("Employees.API.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            FirstName = "Irakli",
                            LastName = "Rogava"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            FirstName = "Giorgi",
                            LastName = "Omanadze"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 2,
                            FirstName = "Giorgi",
                            LastName = "Jibladze"
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 3,
                            FirstName = "Lizi",
                            LastName = "Nemsiwverdize"
                        });
                });

            modelBuilder.Entity("Employees.API.Employee", b =>
                {
                    b.HasOne("Employees.API.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
