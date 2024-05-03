using Api.Extensions;
using Application;
using Application.Middlewares;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureSwagger();

builder.Services.ConfigureAuth(builder.Configuration);

builder.Services.AddApplication()
	.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

app.UseMiddleware<ErrorHandlerMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();