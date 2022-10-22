﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RepositoryLayer.DataAccess;

#nullable disable

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20221021055218_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DomainLayer.Models.EmployeeJobHistories", b =>
                {
                    b.Property<Guid>("EmployeeJobHistoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("Employeeid")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<Guid>("Positionid")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("EmployeeJobHistoryid");

                    b.HasIndex("Employeeid");

                    b.HasIndex("Positionid");

                    b.ToTable("EmployeeJobHistories");
                });

            modelBuilder.Entity("DomainLayer.Models.Employees", b =>
                {
                    b.Property<Guid>("Employeeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("EmployeeCode")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("ISDisabled")
                        .HasColumnType("boolean");

                    b.Property<Guid>("Personid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Positionid")
                        .HasColumnType("uuid");

                    b.Property<int>("Salary")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Employeeid");

                    b.HasIndex("Personid");

                    b.HasIndex("Positionid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DomainLayer.Models.People", b =>
                {
                    b.Property<Guid>("Personid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.HasKey("Personid");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("DomainLayer.Models.Positions", b =>
                {
                    b.Property<Guid>("Positionid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("PositionName")
                        .HasColumnType("text");

                    b.HasKey("Positionid");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("DomainLayer.Models.EmployeeJobHistories", b =>
                {
                    b.HasOne("DomainLayer.Models.Employees", "employees")
                        .WithMany()
                        .HasForeignKey("Employeeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Models.Positions", "positions")
                        .WithMany()
                        .HasForeignKey("Positionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employees");

                    b.Navigation("positions");
                });

            modelBuilder.Entity("DomainLayer.Models.Employees", b =>
                {
                    b.HasOne("DomainLayer.Models.People", "people")
                        .WithMany()
                        .HasForeignKey("Personid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Models.Positions", "positions")
                        .WithMany()
                        .HasForeignKey("Positionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("people");

                    b.Navigation("positions");
                });
#pragma warning restore 612, 618
        }
    }
}
