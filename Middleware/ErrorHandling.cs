using Drinks_app.Exception;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Drinks_app.Middleware
{
    public class ErrorHandling : IMiddleware
    {

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
            }
            catch (NotFoundException notFoundException)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsJsonAsync(notFoundException.Message);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(argumentOutOfRangeException.Message);
            }
            catch (IndexOutOfRangeException indexOutOfRangeException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(indexOutOfRangeException.Message);
            }
            catch (InvalidOperationException invalidOperationException)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsJsonAsync(invalidOperationException.Message);
            }
            catch (SystemException e)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync("Something went wrong");
            }
        }
    }
}