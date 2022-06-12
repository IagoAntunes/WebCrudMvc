using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVCSQL.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }//Falar pro Entity quais modelos que ele gerencie
    }
}
