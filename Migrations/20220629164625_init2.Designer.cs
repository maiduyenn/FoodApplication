﻿// <auto-generated />
using System;
using FoodApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodApplication.Migrations
{
    [DbContext(typeof(AuthContext))]
    [Migration("20220629164625_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodApplication.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9950ff9c-3353-4c45-97a8-3d5491a54fda",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "System",
                            LockoutEnabled = true,
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPLUcHk23IBMnFFrd1c9VF7X3FRJpOY6EVE4AkYxFVryROxo8CHky56vLrhv1/yoZw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c5666f9f-fc48-42b3-844e-9d199d2a55a8",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a4ba25e1-8560-4cc1-bdac-d8927c0e5079",
                            EmailConfirmed = false,
                            FirstName = "Duyen",
                            LastName = "Nguyen",
                            LockoutEnabled = true,
                            NormalizedUserName = "DUYEN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENJ0Ic6g/hWGCEVzumXyYnLbhn0tMhCdZjeFFwlK/0VhdJ9sxtP9ffCgSlSlnoMmAg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "579d4e26-14df-4625-b856-4e4124013a50",
                            TwoFactorEnabled = false,
                            UserName = "duyen@gmail.com"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3c7e5dd9-b3d5-442d-8254-58ff3e79d5f8",
                            EmailConfirmed = false,
                            FirstName = "Quyen",
                            LastName = "Pham",
                            LockoutEnabled = true,
                            NormalizedUserName = "QUYEN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGPkjHY233kpKUoh+P6gdT78+DyhsBnQSbxRyP9rX+I9AAY2j+8PGSOc4/rH2UOGxA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "41c7d8f5-4f0a-489c-92c2-d31013143be5",
                            TwoFactorEnabled = false,
                            UserName = "quyen@gmail.com"
                        });
                });

            modelBuilder.Entity("FoodApplication.Models.OrderDetailModel", b =>
                {
                    b.Property<Guid>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("FoodApplication.Models.OrderModel", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodApplication.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("ac841026-b8ff-446a-911f-039cfc14b6f7"),
                            Description = "Pizza Hải Sản loại 0 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate0.png",
                            Name = "Pizza siêu ngon số 0 thế giới",
                            Price = 12m
                        },
                        new
                        {
                            ProductId = new Guid("a489e2a5-fe0f-4056-90a0-f3f58c76653f"),
                            Description = "Pizza Hải Sản loại 1 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate1.png",
                            Name = "Pizza siêu ngon số 1 thế giới",
                            Price = 13m
                        },
                        new
                        {
                            ProductId = new Guid("101370c6-df29-43d6-8af1-beb2b1def226"),
                            Description = "Pizza Hải Sản loại 2 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate2.png",
                            Name = "Pizza siêu ngon số 2 thế giới",
                            Price = 14m
                        },
                        new
                        {
                            ProductId = new Guid("f07ac05e-f132-4d22-b72c-9b0d4a40525d"),
                            Description = "Pizza Hải Sản loại 3 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate3.png",
                            Name = "Pizza siêu ngon số 3 thế giới",
                            Price = 15m
                        },
                        new
                        {
                            ProductId = new Guid("284587a9-9189-4c4f-86e1-81f12f04dd0a"),
                            Description = "Pizza Hải Sản loại 4 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate4.png",
                            Name = "Pizza siêu ngon số 4 thế giới",
                            Price = 16m
                        },
                        new
                        {
                            ProductId = new Guid("e852c4aa-1b14-403d-a2a5-00f3eee98284"),
                            Description = "Pizza Hải Sản loại 5 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate5.png",
                            Name = "Pizza siêu ngon số 5 thế giới",
                            Price = 17m
                        },
                        new
                        {
                            ProductId = new Guid("6c7b65e4-0951-4da9-9398-dac61df942e4"),
                            Description = "Pizza Hải Sản loại 6 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate6.png",
                            Name = "Pizza siêu ngon số 6 thế giới",
                            Price = 18m
                        },
                        new
                        {
                            ProductId = new Guid("e6c30fe5-3af1-4f32-bffc-f2eab050cb30"),
                            Description = "Pizza Hải Sản loại 7 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate7.png",
                            Name = "Pizza siêu ngon số 7 thế giới",
                            Price = 19m
                        },
                        new
                        {
                            ProductId = new Guid("f8d834c7-bfcf-4ff5-9db3-6b86fa592785"),
                            Description = "Pizza Hải Sản loại 8 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate8.png",
                            Name = "Pizza siêu ngon số 8 thế giới",
                            Price = 20m
                        },
                        new
                        {
                            ProductId = new Guid("419f5ff7-f658-4e70-be59-fbd56e36bbc4"),
                            Description = "Pizza Hải Sản loại 9 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate9.png",
                            Name = "Pizza siêu ngon số 9 thế giới",
                            Price = 21m
                        });
                });

            modelBuilder.Entity("FoodApplication.Models.UserRank", b =>
                {
                    b.Property<int>("UserRankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRankId"), 1L, 1);

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<Guid?>("RankId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("TotalSpent")
                        .HasColumnType("float");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserRankId");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            ConcurrencyStamp = "aeca2508-8f5c-41e1-b9fa-46135ff2d3ce",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                            ConcurrencyStamp = "7514831f-79ca-4a5e-9344-278f717f29a3",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
                        },
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FoodApplication.Models.OrderDetailModel", b =>
                {
                    b.HasOne("FoodApplication.Models.OrderModel", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
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
                    b.HasOne("FoodApplication.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FoodApplication.Areas.Identity.Data.ApplicationUser", null)
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

                    b.HasOne("FoodApplication.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FoodApplication.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodApplication.Models.OrderModel", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}