using fptbookshop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fptbookshop.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Product> Images { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        // SeedData - chèn ngay bốn sản phẩm khi bảng Product được tạo
        builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    Name = "Đá phong thuỷ tự nhiên",
                    Image = "",
                    Description = "Số 1 cao 40cm rộng 20cm dày 20cm màu xanh lá cây đậm",
                    Price = 1000000
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "Đèn đá muối hình tròn",
                    Image = "",
                    Description = "Trang trí trong nhà Chất liệu : • Đá muối",
                    Price = 1500000
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "Tranh sơn mài",
                    Image = "" ,
                    Description = "Tranh sơn mài loại nhỏ 15x 15 giá 50.000",
                    Price = 50000
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Tranh sơn dầu - Ngựa",
                    Image = "",
                    Description = "Nguyên liệu thể hiện :    Sơn dầu",
                    Price = 450000
                }
        );

    }
    
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255); 
    }
}



        