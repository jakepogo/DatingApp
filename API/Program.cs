using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// to keep this file clean we are including files with extension mesthods 
// in our extensions directory to perform our Service related tasks
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod()
    .WithOrigins("https://localhost:4200"));

app.UseAuthentication();// Checks for Valid token
app.UseAuthorization();// Checks for Rights with Token

//app.UseHttpsRedirection();

app.MapControllers();

app.Run();
