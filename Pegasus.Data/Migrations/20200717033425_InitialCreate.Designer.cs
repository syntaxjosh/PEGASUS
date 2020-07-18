﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pegasus.Data;

namespace Pegasus.Data.Migrations
{
    [DbContext(typeof(PegasusDbContext))]
    [Migration("20200717033425_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Pegasus.Data.Barangay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BarangayAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("BarangayLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("BarangayLogoPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("BarangayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BarangayQrCode")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Barangay");
                });

            modelBuilder.Entity("Pegasus.Data.LguProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("LguAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("LguLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("LguLogoPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("LguName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LguQrCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LguProfile");
                });

            modelBuilder.Entity("Pegasus.Data.PersonProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BarangayId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BgryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LguId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("PicPath")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrincipalPersonId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("QDateEnded")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("QDateStarted")
                        .HasColumnType("TEXT");

                    b.Property<int?>("QDays")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QrCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BarangayId");

                    b.HasIndex("LguId");

                    b.ToTable("PersonProfile");
                });

            modelBuilder.Entity("Pegasus.Data.PersonProfile", b =>
                {
                    b.HasOne("Pegasus.Data.Barangay", "Barangay")
                        .WithMany()
                        .HasForeignKey("BarangayId");

                    b.HasOne("Pegasus.Data.LguProfile", "Lgu")
                        .WithMany()
                        .HasForeignKey("LguId");
                });
#pragma warning restore 612, 618
        }
    }
}
