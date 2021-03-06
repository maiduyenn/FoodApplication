using FoodApplication.Areas.Identity.Data;
using FoodApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FoodApplication.Utilities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            IList<Product> listproducts = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                listproducts.Add(new Product
                {
                    ProductId = Guid.NewGuid(),
                    Name = $"Pizza siêu ngon số {i} thế giới",
                    ImageUrl = $"/images/plate{i}.png",
                    Description = $"Pizza Hải Sản loại {i} Xốt Pesto Với Hải Sản (Tôm, Mực) Nhân Đôi Cùng Với Nấm Trên Nền Xốt Pesto Đặc Trưng, Phủ Phô Mai Mozzarella Từ New Zealand Và Quế Tây.",
                    Price = 12 + i
                }); ;
            }
            modelBuilder.Entity<Product>().HasData(listproducts.AsEnumerable());

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "Admin".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "User", NormalizedName = "User".ToUpper() });

            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(
           new ApplicationUser
           {
               Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
               FirstName = "Admin",
               LastName = "System",
               UserName = "admin@gmail.com",
               NormalizedUserName = "ADMIN@GMAIL.COM",
               PasswordHash = hasher.HashPassword(null, "Admin@123"),
               LockoutEnabled = true
           }, new ApplicationUser
           {
               Id = "8e445865-a24d-4543-a6c6-9443d048cdb7", // primary key
               FirstName = "Duyen",
               LastName = "Nguyen",
               UserName = "duyen@gmail.com",
               NormalizedUserName = "DUYEN@GMAIL.COM",
               PasswordHash = hasher.HashPassword(null, "Duyen@123"),
               LockoutEnabled = true
           }, new ApplicationUser
           {
               Id = "8e445865-a24d-4543-a6c6-9443d048cdb8", // primary key
               FirstName = "Quyen",
               LastName = "Pham",
               UserName = "quyen@gmail.com",
               NormalizedUserName = "QUYEN@GMAIL.COM",
               PasswordHash = hasher.HashPassword(null, "Quyen@123"),
               LockoutEnabled = true
           }
       );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            }, new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb7"
            }, new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8"
            }
        );
            modelBuilder.Entity<Ranking>().HasData(
                new Ranking { RankId = new Guid("2b5e174e-3b0e-446f-86af-483d56fd7210"), RankName = "Broze", Discount = 5, Value = 0, TotalSpent = 100 },
                new Ranking { RankId = new Guid("2c5e174e-3b0e-446f-86af-483d56fd7210"), RankName = "Silver", Discount = 10, Value = 1, TotalSpent = 200 },
                new Ranking { RankId = new Guid("2d5e174e-3b0e-446f-86af-483d56fd7210"), RankName = "Gold", Discount = 20, Value = 2, TotalSpent = 300 });

            modelBuilder.Entity<ReportTarget>().HasData(
                new ReportTarget { TargetId = new Guid("2d5e174e-3b0e-446f-86af-483d56fd8210"), Target = 2000 });
        }
    }
}
