using Microsoft.EntityFrameworkCore;
using TaskManager.Configurations;
using TaskManager.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
builder.Services.AddDbContext<MainDbContext>(
                o => o.UseNpgsql(builder.Configuration.GetConnectionString("TaskManager_Db"))
            );
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll",
        b => b.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()
        );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
