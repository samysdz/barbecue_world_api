using Barbecue.World.Application.Barbecue;
using Barbecue.World.Data.Barbecue;
using Barbecue.World.Data.DB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BarbecueDbContext>();

builder.Services.AddScoped<IBarbecueApplication, BarbecueApplication>();
builder.Services.AddScoped<IBarbecueRepository, BarbecueRepository>();


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
