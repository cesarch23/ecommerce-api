using EcommerceAPI.Database;
using EcommerceAPI.Services;
using Microsoft.EntityFrameworkCore;
using store_app.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services 
builder.Services.AddScoped<ProductoServicio>();
builder.Services.AddScoped<ProductoVendidoService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<VentaService>();

//database 
builder.Services.AddDbContext<EcommerceContext>(options =>
{
    options.UseSqlServer("Data Source=LpCesarCh;Initial Catalog=store;Integrated Security=True;");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
