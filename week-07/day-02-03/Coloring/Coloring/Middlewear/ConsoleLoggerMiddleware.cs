using Coloring.Coloring;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coloring.Middlewear
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        public IColor Color { get; set; }
        public ConsoleLoggerMiddleware(IColor color)
        {
            Color = color;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Color.PrintColor();

            return next(context);
        }
    }
}
