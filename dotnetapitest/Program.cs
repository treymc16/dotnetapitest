using System.Linq;

var builder = WebApplication.CreateBuilder(args);

using var db = new ItemsContext();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/items", () =>
{
    var items = db.Items.ToList();
    return items;
})
.WithName("Items")
.WithOpenApi();

app.MapGet("/items/{id}", (int id) =>
{
    var item = db.Items.Single(i => i.ItemId == id);
    return item;
})
.WithName("Item")
.WithOpenApi();

app.Run();