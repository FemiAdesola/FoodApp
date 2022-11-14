using System;
using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;

namespace PizzaApp.Data
{
	public class ApplicationDbContext: DbContext
	{
		public DbSet<FoodOrder> FoodOrders { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
	}
}

