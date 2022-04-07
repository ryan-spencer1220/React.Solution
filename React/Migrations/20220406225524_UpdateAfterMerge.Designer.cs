﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using React.Models;

namespace React.Migrations
{
    [DbContext(typeof(ReactContext))]
    [Migration("20220406225524_UpdateAfterMerge")]
    partial class UpdateAfterMerge
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("React.Models.Api", b =>
                {
                    b.Property<int>("ApiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Lesson1Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson2Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson3Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson4Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson5Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ModuleComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ApiId");

                    b.ToTable("Apis");
                });

            modelBuilder.Entity("React.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("ApiId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("FundamentalsOneId")
                        .HasColumnType("int");

                    b.Property<int>("FundamentalsTwoId")
                        .HasColumnType("int");

                    b.Property<int>("IntroductionId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NoSQLId")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ReduxId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("React.Models.FundamentalsOne", b =>
                {
                    b.Property<int>("FundamentalsOneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Lesson1Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson2Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson3Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson4Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson5Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson6Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson7Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ModuleComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FundamentalsOneId");

                    b.ToTable("FundamentalsOnes");
                });

            modelBuilder.Entity("React.Models.FundamentalsTwo", b =>
                {
                    b.Property<int>("FundamentalsTwoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Lesson1Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson2Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson3Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson4Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson5Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson6Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson7Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ModuleComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FundamentalsTwoId");

                    b.ToTable("FundamentalsTwos");
                });

            modelBuilder.Entity("React.Models.Introduction", b =>
                {
                    b.Property<int>("IntroductionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Lesson1Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson2Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson3Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ModuleComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IntroductionId");

                    b.ToTable("Introductions");
                });

            modelBuilder.Entity("React.Models.NoSQL", b =>
                {
                    b.Property<int>("NoSQLId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Lesson1Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson2Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson3Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson4Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson5Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson6Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson7Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ModuleComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("NoSQLId");

                    b.ToTable("NoSQLs");
                });

            modelBuilder.Entity("React.Models.Redux", b =>
                {
                    b.Property<int>("ReduxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Lesson1Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson2Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson3Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson4Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson5Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson6Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Lesson7Complete")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ModuleComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ReduxId");

                    b.ToTable("Reduxes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("React.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("React.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("React.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("React.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
