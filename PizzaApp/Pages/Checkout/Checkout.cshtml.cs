﻿using System;
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
        public string PizzaName { get; set; }
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
             PizzaName == "Mushroom" ||
             PizzaName == "Bolognese" ||
             PizzaName == "Hasaiian" ||
             PizzaName == "Carbonara" ||
             PizzaName == "Pepperoni" ||
             PizzaName == "Margerita" ||
             PizzaName == "MeatFeast" ||
             PizzaName == "Seafood" ||
             PizzaName == "Vegetarian"
             )
            {
                PizzaName = PizzaName;
            }
            else if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }


            //if (
            //    ImageTitle == "Mushroom" ||
            //    ImageTitle =="Bolognese" ||
            //    ImageTitle == "Hasaiian" ||
            //    ImageTitle == "Carbonara" ||
            //    ImageTitle == "Pepperoni" ||
            //    ImageTitle == "Margerita" ||
            //    ImageTitle == "MeatFeast" ||
            //    ImageTitle == "Seafood" ||
            //     ImageTitle == "Vegetarian"
            //    )
            //{
            ////    ImageTitle = ImageTitle;
            //}
           if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }


            // database
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
            //
        }

       
     
    }
}
