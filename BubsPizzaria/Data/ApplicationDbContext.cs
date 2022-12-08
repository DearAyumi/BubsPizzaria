using Microsoft.EntityFrameworkCore;
using BubsPizzaria.Models;

namespace BubsPizzaria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrders> PizzaOrder { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
    }
}
