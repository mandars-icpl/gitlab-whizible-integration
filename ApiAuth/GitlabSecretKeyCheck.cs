using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace ApiAuth
{
    public class GitlabSecretKeyCheck(RequestDelegate next, string xApiToken)
    {
        private readonly RequestDelegate _next = next;

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (httpContext.Request.Path == "/")
            {
                await _next(httpContext);
                return;
            }

            if (httpContext.Request.Headers.TryGetValue("X-Gitlab-Token", out StringValues value))
            {
                if (xApiToken == value)
                {
                    await _next(httpContext);
                    return;
                }
                else
                {
                    //return 403
                    httpContext.Response.StatusCode = 403;
                }
            }
            else
            {
                //return 401
                httpContext.Response.StatusCode = 401;
            }
        }
    }
}
