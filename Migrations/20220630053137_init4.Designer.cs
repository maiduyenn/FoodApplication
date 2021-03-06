// <auto-generated />
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
    [Migration("20220630053137_init4")]
    partial class init4
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
                            ConcurrencyStamp = "c2d3c6c6-79e9-4ef9-ba9e-ae60e59a0aca",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "System",
                            LockoutEnabled = true,
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPyNDcZ0hOD4svh9lffJxK1HunKKSLXBFhaMsR56gxESj3zw7kJaj3MFIM4sl+x9xw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "671b0044-d668-49fd-b27c-7088bdfed41b",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "33970939-ca0b-4e2c-bf1c-5561f8c95503",
                            EmailConfirmed = false,
                            FirstName = "Duyen",
                            LastName = "Nguyen",
                            LockoutEnabled = true,
                            NormalizedUserName = "DUYEN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIkpJFc1DIPesloOMdBMGL8A6TXRT0XiaOuogb4R6rmKXLcA5tJQHpPnIV++fLc2tQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5f12416f-d7cb-4c99-98c7-567db3032050",
                            TwoFactorEnabled = false,
                            UserName = "duyen@gmail.com"
                        },
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d5bf447-39e6-4e62-bde3-b569aa2a587e",
                            EmailConfirmed = false,
                            FirstName = "Quyen",
                            LastName = "Pham",
                            LockoutEnabled = true,
                            NormalizedUserName = "QUYEN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENfooY11cpkl97BXKRqz2Yq6iXMeShfZalfRkbARQN/+UbFIF2+bA52JZPUwcR5WNw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ce03c8f-ee97-4f82-ae09-d8ab932c4efb",
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
                            ProductId = new Guid("77c6f995-815e-4c29-bb47-d62fd78c96af"),
                            Description = "Pizza Hải Sản loại 0 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate0.png",
                            Name = "Pizza siêu ngon số 0 thế giới",
                            Price = 12m
                        },
                        new
                        {
                            ProductId = new Guid("a26cba11-474d-42ae-aaa9-6d698a463830"),
                            Description = "Pizza Hải Sản loại 1 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate1.png",
                            Name = "Pizza siêu ngon số 1 thế giới",
                            Price = 13m
                        },
                        new
                        {
                            ProductId = new Guid("2ca51096-d113-4ec6-9222-bf31e73e9fce"),
                            Description = "Pizza Hải Sản loại 2 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate2.png",
                            Name = "Pizza siêu ngon số 2 thế giới",
                            Price = 14m
                        },
                        new
                        {
                            ProductId = new Guid("10835859-9455-47fd-b500-adaea0fa0e93"),
                            Description = "Pizza Hải Sản loại 3 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate3.png",
                            Name = "Pizza siêu ngon số 3 thế giới",
                            Price = 15m
                        },
                        new
                        {
                            ProductId = new Guid("f2931a91-4912-4b11-a0c2-92ab8ab721bb"),
                            Description = "Pizza Hải Sản loại 4 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate4.png",
                            Name = "Pizza siêu ngon số 4 thế giới",
                            Price = 16m
                        },
                        new
                        {
                            ProductId = new Guid("3c3393a6-94cf-4219-a347-aca02081780c"),
                            Description = "Pizza Hải Sản loại 5 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate5.png",
                            Name = "Pizza siêu ngon số 5 thế giới",
                            Price = 17m
                        },
                        new
                        {
                            ProductId = new Guid("29d98ab0-a796-4ebf-ab2f-8f0c64affbe3"),
                            Description = "Pizza Hải Sản loại 6 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate6.png",
                            Name = "Pizza siêu ngon số 6 thế giới",
                            Price = 18m
                        },
                        new
                        {
                            ProductId = new Guid("8acd6ffb-318c-477d-989e-e96ad9820145"),
                            Description = "Pizza Hải Sản loại 7 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate7.png",
                            Name = "Pizza siêu ngon số 7 thế giới",
                            Price = 19m
                        },
                        new
                        {
                            ProductId = new Guid("e6b419f4-136d-4e6a-9c4f-81906df1937e"),
                            Description = "Pizza Hải Sản loại 8 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate8.png",
                            Name = "Pizza siêu ngon số 8 thế giới",
                            Price = 20m
                        },
                        new
                        {
                            ProductId = new Guid("2f77b5cb-9d89-4ca8-bd68-524b1d8ddbec"),
                            Description = "Pizza Hải Sản loại 9 Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                            ImageUrl = "/images/plate9.png",
                            Name = "Pizza siêu ngon số 9 thế giới",
                            Price = 21m
                        });
                });

            modelBuilder.Entity("FoodApplication.Models.Ranking", b =>
                {
                    b.Property<Guid?>("RankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("RankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalSpent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("RankId");

                    b.ToTable("Ranking");

                    b.HasData(
                        new
                        {
                            RankId = new Guid("2b5e174e-3b0e-446f-86af-483d56fd7210"),
                            Discount = 5,
                            RankName = "Broze",
                            TotalSpent = 100m,
                            Value = 0
                        },
                        new
                        {
                            RankId = new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"),
                            Discount = 10,
                            RankName = "Silver",
                            TotalSpent = 200m,
                            Value = 1
                        },
                        new
                        {
                            RankId = new Guid("2d5e174e-3b0e-446f-86af-483d56fd7210"),
                            Discount = 20,
                            RankName = "Gold",
                            TotalSpent = 300m,
                            Value = 2
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

                    b.Property<decimal?>("TotalSpent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserRankId");

                    b.ToTable("UserRank");
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
                            ConcurrencyStamp = "ad218d1d-0515-4827-b62d-5710218d98ba",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                            ConcurrencyStamp = "19d84541-4122-47af-98ae-dc0f99dbb7d9",
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
