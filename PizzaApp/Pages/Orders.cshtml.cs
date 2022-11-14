using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Data;
using PizzaApp.Models;

namespace PizzaApp.Pages
{
	public class OrdersModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<PizzaOrder> FoodOrders = new List<PizzaOrder>();

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            FoodOrders = _context.FoodOrders.ToList();

        }
    }
}
