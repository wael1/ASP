using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware_03
{
    public class Header
    {
        private readonly RequestDelegate _next;

        public Header(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            foreach (var header in context.Request.Headers)
            {
                await context.Response.WriteAsync($"\n {header.Key}: {header.Value}");
            }

            await _next(context);
        }
    }
}
