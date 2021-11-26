﻿// <auto-generated />
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoMVC.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211126061247_create_Khoa_chuyennganh")]
    partial class create_Khoa_chuyennganh
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("DemoMVC.Models.Car", b =>
                {
                    b.Property<string>("CarID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CarName")
                        .HasColumnType("TEXT");

                    b.HasKey("CarID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("DemoMVC.Models.ChuyenNganh", b =>
                {
                    b.Property<int>("ChuyenNganhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChuyenNganhName")
                        .HasColumnType("TEXT");

                    b.Property<int>("KhoaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChuyenNganhId");

                    b.HasIndex("KhoaId");

                    b.ToTable("ChuyenNganh");
                });

            modelBuilder.Entity("DemoMVC.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DemoMVC.Models.Khoa", b =>
                {
                    b.Property<int>("KhoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KhoaName")
                        .HasColumnType("TEXT");

                    b.HasKey("KhoaId");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("DemoMVC.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonName")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("DemoMVC.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DemoMVC.Models.ChuyenNganh", b =>
                {
                    b.HasOne("DemoMVC.Models.Khoa", "Khoa")
                        .WithMany("ChuyenNganhs")
                        .HasForeignKey("KhoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoa");
                });

            modelBuilder.Entity("DemoMVC.Models.Khoa", b =>
                {
                    b.Navigation("ChuyenNganhs");
                });
#pragma warning restore 612, 618
        }
    }
}
