using Microsoft.EntityFrameworkCore;
using RazorPizzria.Models;

namespace RazorPizzria.Data
{
	public class AppDBContex:DbContext
	{
		public DbSet<PizzaOrder> PizzaOrders { get; set;}

        public AppDBContex(DbContextOptions<AppDBContex> options)
            :base(options)
        {
            
        }
    }
}
