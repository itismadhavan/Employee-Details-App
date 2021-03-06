﻿// <auto-generated />
using System;
using Employee_Details_App.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Employee_Details_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191119001822_3")]
    partial class _3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employee_Details_App.EmployeeDetail", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("EmployeeDetails");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Email = "Test@gmail.com",
                            EmployeeGuid = new Guid("11af177e-ad4d-4118-87c1-4bb3645054a0"),
                            MobileNumber = "7788990099",
                            Name = "Test Employee"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Email = "Test2@gmail.com",
                            EmployeeGuid = new Guid("dc25d6eb-0230-4069-898e-18c7724f7901"),
                            MobileNumber = "8899009977",
                            Name = "Test Employee 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
