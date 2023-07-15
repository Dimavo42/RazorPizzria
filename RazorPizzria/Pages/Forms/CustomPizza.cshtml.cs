using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzria.Models;

namespace RazorPizzria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.Cheese) PizzaPrice += 1;
			if (Pizza.Tuna) PizzaPrice += 1;
			if (Pizza.Ham) PizzaPrice += 1;
			if (Pizza.Beff) PizzaPrice += 1;
            return RedirectToPage("/CheckOut/CheckOut" ,new { PizzaPrice , Pizza.PizzaName});

		}
    }
}
