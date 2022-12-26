using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware_03
{
    public class Request
    {
        private readonly RequestDelegate _next;
        public Request(RequestDelegate next) 
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Query.Keys.Count > 0)
            {
                foreach (var key in context.Request.Query.Keys)
                {
                    var data = context.Request.Query[key];
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        context.Request.Headers.Append(key, data);
                    }
                }
            }
            await _next(context);
        }
    }
}
