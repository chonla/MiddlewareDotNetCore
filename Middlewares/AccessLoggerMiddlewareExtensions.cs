using Microsoft.AspNetCore.Builder;

namespace MiddlewareDotNetCore.Middlewares
{
    public static class AccessLoggerMiddlewareExtensions
    {
        public static IApplicationBuilder UseAccessLogger(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AccessLoggerMiddleware>();
        }
    }
}