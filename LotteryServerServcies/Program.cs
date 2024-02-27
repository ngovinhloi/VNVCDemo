using LotteryServerServcies.Data;
using LotteryServerServcies.Repository;
using LotteryServerServcies.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//----------------------
//Enable CORS
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
     .AllowAnyHeader());
});

//JSON Serializer
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft
    .Json.ReferenceLoopHandling.Ignore)
    .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
    = new DefaultContractResolver());
//--------------------
var connectionstring = builder.Configuration.GetConnectionString("LotteryServerConn");
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(connectionstring));
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<LotteryServcies>();
builder.Services.AddScoped<ILotteryRepository, LotteryRepository>();

builder.Services.AddLogging(
    builder =>
    {
        builder.AddFilter("Microsoft.Hosting", LogLevel.None)
               .AddFilter("System", LogLevel.Warning)
               .AddFilter("NToastNotify", LogLevel.Warning)
               .AddConsole();
    });
var app = builder.Build();


//----------------------
//Enable CORS
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
//----------------------

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
