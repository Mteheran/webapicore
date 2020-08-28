using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace weapicore.Middlewares
{
    public class ParameterMiddleware
    {
        readonly RequestDelegate requestDelegate;
        
        public ParameterMiddleware(RequestDelegate request)
        {
            requestDelegate = request;
        }

        public async Task Invoke(HttpContext context)
        {
            await requestDelegate(context);

            if(context.Request.Query.FirstOrDefault(p=> p.Key=="status").Key!=null)
                await context.Response.WriteAsync("working...");
           
        }
    }

    public static class ParameterMiddlewareExtension
    {
        public static IApplicationBuilder UseParameterMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ParameterMiddleware>();
        }
    }
}