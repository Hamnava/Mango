using Microsoft.EntityFrameworkCore;

namespace Mango.ShoppingCartAPI.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        //public DbSet<Product> Products { get; set; }

    }
}
