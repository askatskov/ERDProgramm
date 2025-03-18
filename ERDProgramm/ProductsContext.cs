using ERDProgramm;
using Microsoft.EntityFrameworkCore;

namespace ERDProgramm;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Electronics" },
            new Category { CategoryId = 2, Name = "Clothing" },
            new Category { CategoryId = 3, Name = "Furniture" },
            new Category { CategoryId = 4, Name = "Books" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Smartphone" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Laptop" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Headphones" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Smartwatch" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Camera" },
            new Product { ProductId = 6, CategoryId = 1, Name = "Tablet" },
            new Product { ProductId = 7, CategoryId = 1, Name = "Bluetooth Speaker" },
            new Product { ProductId = 8, CategoryId = 1, Name = "Charger" },
            new Product { ProductId = 9, CategoryId = 1, Name = "Wireless Mouse" },
            new Product { ProductId = 10, CategoryId = 1, Name = "Power Bank" },
            new Product { ProductId = 11, CategoryId = 2, Name = "T-Shirt" },
            new Product { ProductId = 12, CategoryId = 2, Name = "Jeans" },
            new Product { ProductId = 13, CategoryId = 2, Name = "Sweater" },
            new Product { ProductId = 14, CategoryId = 2, Name = "Jacket" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Dress" },
            new Product { ProductId = 16, CategoryId = 2, Name = "Shoes" },
            new Product { ProductId = 17, CategoryId = 2, Name = "Socks" },
            new Product { ProductId = 18, CategoryId = 2, Name = "Scarf" },
            new Product { ProductId = 19, CategoryId = 2, Name = "Hat" },
            new Product { ProductId = 20, CategoryId = 2, Name = "Gloves" },
            new Product { ProductId = 21, CategoryId = 3, Name = "Sofa" },
            new Product { ProductId = 22, CategoryId = 3, Name = "Table" },
            new Product { ProductId = 23, CategoryId = 3, Name = "Chair" },
            new Product { ProductId = 24, CategoryId = 4, Name = "Novel" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Cookbook" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Biography" },
            new Product { ProductId = 27, CategoryId = 4, Name = "Science Fiction" },
            new Product { ProductId = 28, CategoryId = 4, Name = "Fantasy" },
            new Product { ProductId = 29, CategoryId = 4, Name = "History" },
            new Product { ProductId = 30, CategoryId = 4, Name = "Poetry" },
            new Product { ProductId = 31, CategoryId = 4, Name = "Comic" },
            new Product { ProductId = 32, CategoryId = 4, Name = "Magazine" },
            new Product { ProductId = 33, CategoryId = 4, Name = "Children's Book" });

    }
}