using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDependencyInjection.Models
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        public ConsoleLoggerMiddleware(Printer printer)
        {
            printer.Log("hello");
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");

            return next(context);
        }
    }
}
