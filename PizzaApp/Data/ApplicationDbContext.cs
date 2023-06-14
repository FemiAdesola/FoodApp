using System;
using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;

namespace PizzaApp.Data
{
	public class ApplicationDbContext: DbContext
	{
		public DbSet<FoodOrder> FoodOrders { get; set; }

		// public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		// {

		// }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration config) : base(options) => _config = config;
		 static ApplicationDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior",true);
        }
        private readonly IConfiguration _config;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connString = _config.GetConnectionString("DefaultConnection");
            optionsBuilder
                .UseNpgsql(connString)
                // .AddInterceptors(new AppDbContextSaveChangesInterceptor())
                .UseSnakeCaseNamingConvention();
        }
	}
}

