using Microsoft.EntityFrameworkCore;
using GreenOutdoorsCo.Api.Models;
using System;

namespace GreenOutdoorsCo.Api.Data
{
  public class GreenOutdoorsDbContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public GreenOutdoorsDbContext(DbContextOptions<GreenOutdoorsDbContext> options) : base(options)
    {
      Users = Set<User>();
      Products = Set<Product>();
      Orders = Set<Order>();
      OrderItems = Set<OrderItem>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySql("server=localhost;database=greenoutdoorsco;user=root;", new MySqlServerVersion(new Version(8, 0, 33)));
    }
  }
}
