using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete;

public class ECommerceContext : DbContext
{
    private IConfiguration _configuration;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=ECommerceDb; User Id=sa; Password=Parola6751; TrustServerCertificate=True");
        
    }
    
    public DbSet<Product> Products { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
    //public DbSet<CreditCard> CreditCards { get; set; }
    
    public DbSet<Address> Addresses { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    public DbSet<OperationClaim> OperationClaims { get; set; }
    
}