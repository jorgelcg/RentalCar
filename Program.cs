using Web.Api.Domain.Interfaces;
using Web.Api.Domain.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<RentSevice>(); 

// Add services to the container.
void ConfigureServices(IServiceCollection services)
{
   
    services.AddControllers();
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

