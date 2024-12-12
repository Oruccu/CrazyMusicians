using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // MVC'yi ekledik
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Statik dosyaları desteklemek için
app.UseRouting();

app.UseAuthorization();

app.UseDefaultFiles(); // default açýlacak dosya: index.html
app.UseStaticFiles(); // wwwroot halka açýk

app.MapControllers(); // API için
app.MapDefaultControllerRoute(); // MVC için

app.Run();
