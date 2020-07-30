﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MutualAidRefactorEFCore.Data.Context;

namespace MutualAidRefactorEFCore.Data.Migrations
{
    [DbContext(typeof(MutualAidContext))]
    [Migration("20200721133903_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Common")
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MutualAidRefactorEFCore.Data.Entities.AcceptedRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.HasIndex("UserId");

                    b.ToTable("Accepted Request","Common");
                });

            modelBuilder.Entity("MutualAidRefactorEFCore.Data.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bread")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CannedFood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cereal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conditioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dairy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disinfectant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HandSoap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Meat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pantry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperTowels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Produce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seafood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shampoo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToiletPaper")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toothpaste")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Request","Common");
                });

            modelBuilder.Entity("MutualAidRefactorEFCore.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("User","Common");
                });

            modelBuilder.Entity("MutualAidRefactorEFCore.Data.Entities.AcceptedRequest", b =>
                {
                    b.HasOne("MutualAidRefactorEFCore.Data.Entities.Request", "Request")
                        .WithMany("AcceptedRequests")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MutualAidRefactorEFCore.Data.Entities.User", "User")
                        .WithMany("AcceptedRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MutualAidRefactorEFCore.Data.Entities.Request", b =>
                {
                    b.HasOne("MutualAidRefactorEFCore.Data.Entities.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
