using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPizzria.Data;
using RazorPizzria.Models;

namespace RazorPizzria.Pages
{
    public class OrdersModel : PageModel
    {

        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
        private readonly AppDBContex _context;
		public OrdersModel(AppDBContex context)
        {
			_context = context;
		}
        public void OnGet()
        {
			PizzaOrders = _context.PizzaOrders.ToList();
		}

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var contact = await _context.PizzaOrders.FirstOrDefaultAsync(
                (x)=> x.Id == id);
            if (contact != null)
            {
                _context.PizzaOrders.Remove(contact);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

    }
}
