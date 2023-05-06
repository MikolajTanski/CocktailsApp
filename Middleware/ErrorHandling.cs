using Drinks_app.Exception;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Drinks_app.Middleware
{
    public class ErrorHandling : IMiddleware
    {
        private readonly ILogger<ErrorHandling> _logger;

        public ErrorHandling(ILogger<ErrorHandling> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (BadRequestException badRequestException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(badRequestException.Message);
                _logger.LogError(badRequestException, $"Error {badRequestException.GetType().Name} occurred at {DateTime.Now}");

            }
            catch (NotFoundException notFoundException)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsJsonAsync(notFoundException.Message);
                _logger.LogError(notFoundException, $"Error {notFoundException.GetType().Name} occurred at {DateTime.Now}");

            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(argumentOutOfRangeException.Message);
                _logger.LogError(argumentOutOfRangeException, $"Error {argumentOutOfRangeException.GetType().Name} occurred at {DateTime.Now}");

            }
            catch (IndexOutOfRangeException indexOutOfRangeException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(indexOutOfRangeException.Message);
                _logger.LogError(indexOutOfRangeException, $"Error {indexOutOfRangeException.GetType().Name} occurred at {DateTime.Now}");
            }
            catch (InvalidOperationException invalidOperationException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(invalidOperationException.Message);
                _logger.LogError(invalidOperationException, $"Error {invalidOperationException.GetType().Name} occurred at {DateTime.Now}");
            }
            catch (SystemException e)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync("Something went wrong");
                _logger.LogError(e, $"Error {e.GetType().Name} occurred at {DateTime.Now}");
            }
        }
    }
}