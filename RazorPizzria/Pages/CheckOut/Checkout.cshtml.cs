using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzria.Data;
using RazorPizzria.Models;

namespace RazorPizzria.Pages.CheckOut
{
	[BindProperties(SupportsGet =true)]
	public class CheckoutModel : PageModel
    {

        public string PizzaName { get; set; }
		public float PizzaPrice { get; set; }
		public string ImageTitle { get; set; }

		private readonly AppDBContex _contex;

		public CheckoutModel(AppDBContex contex)
		{
			_contex = contex;
		}
		public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName)) { PizzaName = "Custome"; }
			if (string.IsNullOrWhiteSpace(ImageTitle)) { ImageTitle = "download (1)"; }
			PizzaOrder pizzaOrder = new PizzaOrder()
			{
				PizzaName = PizzaName,
				BasePrice = PizzaPrice
			};
			_contex.Add(pizzaOrder);
			_contex.SaveChanges();

		}
    }
}
