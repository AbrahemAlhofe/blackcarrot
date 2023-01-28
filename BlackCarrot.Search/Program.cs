using BlackCarrot.Data.Contexts;
using BlackCarrot.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductsContext>(
    options => options.UseMySql(
        builder.Configuration.GetConnectionString("DatabaseConnectionString"),
        new MySqlServerVersion(new Version(8, 0))
    )
);

var app = builder.Build();

using (var serviceScope = app.Services.CreateScope())
{
    // Takes all of our migrations files and apply them against the database in case they are not implemented
    serviceScope.ServiceProvider.GetService<ProductsContext>()?.Database.Migrate();
}

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
