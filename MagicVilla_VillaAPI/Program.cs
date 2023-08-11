using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/// <summary>
/// added nuget pkg file
/// Serilog.AspNetCore
///Serilog.Sinks.File
///Serilog.Sinks.Console
    //Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
    //    .WriteTo.File("log/villaLogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();
    //builder.Host.UseSerilog();
/// </summary>

builder.Services.AddControllers(option =>
{
    //option.ReturnHttpNotAcceptable = true; 
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
