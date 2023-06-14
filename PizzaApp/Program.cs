using PizzaApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
   

// Add services to the container.

// To add data to databse service
// builder.Services.AddDbContext<ApplicationDbContext>(options=>
//     {
//         options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
//     }
// );
// //
// "server=localhost;Database=PizzaApp;User=sa;Password=value12345;Encrypt=false; TrustServerCertificate=True"


builder.Services
            .AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

builder.Services.AddDbContext<ApplicationDbContext>(); 

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

