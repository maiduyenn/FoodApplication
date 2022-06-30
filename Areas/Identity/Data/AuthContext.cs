﻿using FoodApplication.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FoodApplication.Models;
using FoodApplication.Utilities;

namespace FoodApplication.Data;

public class AuthContext : IdentityDbContext<ApplicationUser>
{
    public AuthContext(DbContextOptions<AuthContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.Seed();//seeding data
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

    public DbSet<Product>? Product { get; set; }
    public DbSet<OrderModel>? Orders { get; set; }
    public DbSet<OrderDetailModel>? OrderDetails { get; set; }
    public DbSet<UserRank>? UserRank { get; set; }
    public DbSet<FoodApplication.Models.Ranking>? Ranking { get; set; }
    public DbSet<FoodApplication.Models.ReportTarget>? ReportTarget { get; set; }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}

