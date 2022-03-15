﻿// <auto-generated />
using System;
using HomeFinder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeFinder.Migrations
{
    [DbContext(typeof(HomeFinderContext))]
    partial class HomeFinderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeFinder.Models.RealEstate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ConstructionYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormOfLease")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LivingArea")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<string>("Pictures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShowDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RealEstate");
                });

            modelBuilder.Entity("HomeFinder.Models.RegistrationOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RealEstateId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RealEstateId");

                    b.HasIndex("UserId");

                    b.ToTable("RegistrationOfInterest");
                });

            modelBuilder.Entity("HomeFinder.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HomeFinder.Models.RegistrationOfInterest", b =>
                {
                    b.HasOne("HomeFinder.Models.RealEstate", "RealEstate")
                        .WithMany("RegistrationsOfInterest")
                        .HasForeignKey("RealEstateId");

                    b.HasOne("HomeFinder.Models.User", "User")
                        .WithMany("Registrations")
                        .HasForeignKey("UserId");

                    b.Navigation("RealEstate");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HomeFinder.Models.RealEstate", b =>
                {
                    b.Navigation("RegistrationsOfInterest");
                });

            modelBuilder.Entity("HomeFinder.Models.User", b =>
                {
                    b.Navigation("Registrations");
                });
#pragma warning restore 612, 618
        }
    }
}
