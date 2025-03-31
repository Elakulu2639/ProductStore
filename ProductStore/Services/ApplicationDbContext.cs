using Microsoft.EntityFrameworkCore;
using ProductStore.Models;
namespace ProductStore.Services
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Proucts {  get; set; }
    }
}
