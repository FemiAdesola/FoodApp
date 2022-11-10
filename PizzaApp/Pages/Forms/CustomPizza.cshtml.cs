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
        public PizzasModel Pizza  { get; set; }
        public void OnGet()
        {
            
        }
    }
}
