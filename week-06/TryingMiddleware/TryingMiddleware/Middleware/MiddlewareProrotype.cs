using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryingMiddleware.Middleware
{
    public class MiddlewareProrotype
    {
        private readonly RequestDelegate _next;
        public MiddlewareProrotype(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var endpoint = context.GetEndpoint();
            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() is object)
            {
                await _next(context);
                return;
            }

            var id = context.Session.GetInt32("userid");
            if (id > 0)
            {
                await _next(context);
                return;
            }
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
        }
    }
}
