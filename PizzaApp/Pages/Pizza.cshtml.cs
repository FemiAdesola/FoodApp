using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;

namespace PizzaApp.Pages
{
	public class PizzaModel : PageModel
    {
        //temPizzaDB represent database's name
        public List<PizzasModel> temPizzaDB = new List<PizzasModel>()
        {
           new PizzasModel(){
               ImageTitle="Margerita",
               PizzaName="Margerita",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               FinalPrice=4},
            new PizzasModel(){
               ImageTitle="Bolognese",
               PizzaName="Bolognese",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               Pineapple=true,
               Ham=true,
               FinalPrice=10},
             new PizzasModel(){
               ImageTitle="Hawaiian",
               PizzaName="Hawaiian",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               Ham=true,
               Mushroom=true,
               Lohi=true,
               FinalPrice=8},
             new PizzasModel(){
               ImageTitle="Carbonara",
               PizzaName="Carbonara",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               Mushroom=true,
               Ham=true,
               FinalPrice=6},
             new PizzasModel(){
               ImageTitle="Mushroom",
               PizzaName="Mushroom",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               Mushroom=true,
               Pepper=true,
               Tunna=true,
               FinalPrice=7},
             new PizzasModel(){
               ImageTitle="Pepperoni",
               PizzaName="Pepperoni",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               Pepper=true,
               Ham=true,
               Pineapple=true,
               FinalPrice=11},
             new PizzasModel(){
               ImageTitle="Vegetarian",
               PizzaName="Vegetarian",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               Mushroom=true,
               Tunna = true,
               FinalPrice=6},
             new PizzasModel(){
               ImageTitle="MeatFeast",
               PizzaName="Meatfeast",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               Beef=true,
               Pineapple=true,
               FinalPrice=10},
             new PizzasModel(){
               ImageTitle="Seafood",
               PizzaName="Seafood",
               BasePrice = 2,
               TomatoSauce=true,
               Cheese=true,
               Lohi=true,
               Pepper=true,
               FinalPrice=7},
        };
        public void OnGet()
        {
        }
    }
}
