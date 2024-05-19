using System.Net;
using System.Text.Json;
using Application.Common.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Application.Middlewares;

public class ErrorHandlerMiddleware
{
	private readonly RequestDelegate _next;

	public ErrorHandlerMiddleware(RequestDelegate next)
	{
		_next = next ?? throw new ArgumentNullException(nameof(next));
	}

	public async Task InvokeAsync(HttpContext context)
	{
		try
		{
			await _next(context);
		}
		catch (Exception exception)
		{
			await HandleExceptionAsync(context, exception);
		}
	}

	private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
	{
		HttpStatusCode statusCode;
		string message;

		switch (exception)
		{
			case BadRequestException:
				statusCode = HttpStatusCode.BadRequest;
				message = exception.Message;
				break;
			case NotFoundException:
				statusCode = HttpStatusCode.NotFound;
				message = exception.Message;
				break;
			case ConflictException:
				statusCode = HttpStatusCode.Conflict;
				message = exception.Message;
				break;
			case ForbiddenException:
				statusCode = HttpStatusCode.Forbidden;
				message = exception.Message;
				break;
			default:
				statusCode = HttpStatusCode.InternalServerError;
				message = "Erro interno no sistema, tente novamente mais tarde.";
				break;
		}

		Console.WriteLine(exception.Message);
		context.Response.StatusCode = (int)statusCode;
		await context.Response.WriteAsync(JsonSerializer.Serialize(new { statusCode, message }));
	}
}