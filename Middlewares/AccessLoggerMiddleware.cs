using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace MiddlewareDotNetCore.Middlewares {
  public class AccessLoggerMiddleware {
    private readonly RequestDelegate _next;

    public AccessLoggerMiddleware (RequestDelegate next) {
      _next = next;
    }

    public Task Invoke (HttpContext context) {
      Console.WriteLine(context.Request.Path);
      return this._next (context);
    }
  }
}