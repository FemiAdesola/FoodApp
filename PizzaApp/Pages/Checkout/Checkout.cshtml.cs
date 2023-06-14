using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Data;
using PizzaApp.Models;

namespace PizzaApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]

    public class CheckoutModel : PageModel
    {
        public string FoodName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        // database
        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        //

        public void OnGet()
        {

            if (
             FoodName == "Mushroom" ||
             FoodName == "Bolognese" ||
             FoodName == "Hasaiian" ||
             FoodName == "Carbonara" ||
             FoodName == "Pepperoni" ||
             FoodName == "Margerita" ||
             FoodName == "MeatFeast" ||
             FoodName == "Seafood" ||
             FoodName == "Vegetarian"
             )
            {
                FoodName = FoodName;
            }
            else if (string.IsNullOrWhiteSpace(FoodName))
            {
                FoodName = "Custom";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            // database
            FoodOrder foodOrder = new FoodOrder();
            foodOrder.FoodName = FoodName;
            //pizzaOrder.PizzaName = PizzaName;
            foodOrder.BasePrice = PizzaPrice;

            _context.FoodOrders.Add(foodOrder);
            _context.SaveChanges();
            //
        }

       
     
    }
}
