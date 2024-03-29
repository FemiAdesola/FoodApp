﻿using System;
namespace PizzaApp.Models
{
	public class FoodsModel
	{
		public string ImageTitle { get; set; }
        public string FoodName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Pepper { get; set; }
        public bool Beef { get; set; }
        public bool Ham { get; set; }
        public bool Tunna { get; set; }
        public bool Cheese { get; set; }
        public bool Lohi { get; set; }
        public bool Mushroom { get; set; }
        public bool Pineapple { get; set; }

        public float FinalPrice { get; set; }
    }
}

