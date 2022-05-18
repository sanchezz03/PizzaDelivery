using Microsoft.EntityFrameworkCore;
using PizzaDelivery.Models;

namespace PizzaDelivery.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
