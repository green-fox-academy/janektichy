using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using RedditClone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Middlewares
{
    public class MiddlewarePrototype
    {
        private readonly RequestDelegate Next;

        public MiddlewarePrototype(RequestDelegate next)
        {
            Next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var endpoint = context.GetEndpoint();
            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() is object)
            {
                await Next(context);
                return;
            }

            var id = context.Session.GetInt32("userid");
            if (id > 0)
            {
                await Next(context);
            }
            context.Response.StatusCode = StatusCodes.Status403Forbidden;

        }
    }
}
