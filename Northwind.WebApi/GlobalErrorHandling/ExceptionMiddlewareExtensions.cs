using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace Northwind.WebApi.GlobalErrorHandling
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
           {
               appError.Run(async context =>
              {
                  context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                  context.Response.ContentType = "application/json";

                  var contextFeatures = context.Features.Get<IExceptionHandlerFeature>();
                  if (contextFeatures != null)
                  {
                      
                      await context.Response.WriteAsync(new ErrorDetail()
                      {
                          StatusCode = context.Response.StatusCode,
                          Message = "Internal Server Error, lol"
                      }.ToString());
                  }
              });
           });
        }
    }
}
