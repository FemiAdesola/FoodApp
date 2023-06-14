using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;

namespace PizzaApp.Pages
{
	public class FoodModel : PageModel
    {
        //temPizzaDB represent database's name
        public List<FoodsModel> temPizzaDB = new List<FoodsModel>()
        {
           new FoodsModel(){
               ImageTitle="VegPomoSaki",
              FoodName="VegPomoSaki",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               FinalPrice=7},
           new FoodsModel(){
               ImageTitle="MeatFeast",
               FoodName="Meatfeast",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               Beef=true,
               Pineapple=true,
               FinalPrice=10},
             new FoodsModel(){
               ImageTitle="DodoFish",
               FoodName="DodoFish",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               Mushroom=true,
               Ham=true,
               FinalPrice=9},
            new FoodsModel(){
               ImageTitle="RiceChickenDodo",
               FoodName="RiceChickenDodo",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               Pineapple=true,
               Ham=true,
               FinalPrice=13},
             new FoodsModel(){
               ImageTitle="EggPlantain",
              FoodName="EggPlantain",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               Ham=true,
               Mushroom=true,
               Lohi=true,
               FinalPrice=11},

            new FoodsModel(){
               ImageTitle="Mushroom",
               FoodName="Mushroom",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               Mushroom=true,
               Pepper=true,
               Tunna=true,
               FinalPrice=10},
             new FoodsModel(){
               ImageTitle="PepperSoup",
               FoodName="PepperSoup",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               Pepper=true,
               Ham=true,
               Pineapple=true,
               FinalPrice=14},
             new FoodsModel(){
               ImageTitle="ChickenSoup",
               FoodName="ChickenSoup",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               Mushroom=true,
               Tunna = true,
               FinalPrice=9},
             
             new FoodsModel(){
               ImageTitle="AsortedMeat",
               FoodName="AsortedMeat",
               BasePrice = 5,
               TomatoSauce=true,
               Cheese=true,
               Lohi=true,
               Pepper=true,
               FinalPrice=10},
        };
        public void OnGet()
        {
        }
    }
}
