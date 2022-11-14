using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;

namespace PizzaApp.Pages.Forms
{
	public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public FoodsModel Pizza  { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 2;
            if (Pizza.Lohi) PizzaPrice += 2;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Pepper) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Tunna) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 5;

            return RedirectToPage("/Checkout/Checkout",
                new {Pizza.FoodName, PizzaPrice });
           
        }
    }
}
