using Microsoft.EntityFrameworkCore;
using Mongo.Services.ProductAPI.Models;

namespace Mongo.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
