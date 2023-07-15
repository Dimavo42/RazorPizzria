using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzria.Models;

namespace RazorPizzria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzaDB = new List<PizzasModel> 
        { 
            new PizzasModel(){ImageTitle="download (1)",PizzaName= "Margratie v1",BasePrice=2,FinalPrice=2  },
			new PizzasModel(){ImageTitle="download (2)",PizzaName= "Margratie v2",BasePrice=4,FinalPrice = 4  },
			new PizzasModel(){ImageTitle="download",PizzaName= "Margratie v3",BasePrice=8 ,FinalPrice = 8 }
		};
        public void OnGet()
        {
        }
    }
}
