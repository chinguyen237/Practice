// Challenge 1: finished
// - Create a new .Net Core minimal API
// - Create a new class model Category (ID, Name)
// - Create one endpoint to get category data (hard-coded data)
// - Run and test endpoint with postman

using MinimalApiExample.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/categories", () =>
{
var categories = new List<Category>
{
new Category { ID = 1, Name = "Electronics" },
new Category { ID = 2, Name = "Books" },
new Category { ID = 3, Name = "Clothing" }
};
return categories;
});

app.Run();