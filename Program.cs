using Microsoft.Extensions.Options;
using Web.Api.Domain.Interfaces;
using Web.Api.Domain.Services;
using Web.Api.Infrastructure.DBContext;
using Web.Api.Infrastructure.Models;

var builder = WebApplication.CreateBuilder(args);



builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection(nameof(MongoDBSettings)));

builder.Services.AddSingleton<MongoDBContext>(serviceProvider =>
{
    var settings = serviceProvider.GetRequiredService<IOptions<MongoDBSettings>>().Value;
    return new MongoDBContext(settings.ConnectionString, settings.DatabaseName);
});

// Add services to the container.
void ConfigureServices(IServiceCollection services)
{
   
    services.AddControllers();
    builder.Services.AddScoped<IRentInterface, RentSevice>();
    builder.Services.AddScoped<IPickupInterface, PickupService>();
    builder.Services.AddScoped<IDeliverInterface, DeliverServicecs>();
    
        


}
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

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

app.UseHttpsRedirection();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");

app.Run();

