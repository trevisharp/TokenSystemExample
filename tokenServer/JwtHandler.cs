using Microsoft.AspNetCore.Authorization;

public class JwtHandler : AuthorizationHandler<JwtRequirement>
{
    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context, 
        JwtRequirement requirement)
    {
        if (context.Resource is DefaultHttpContext httpContext)
        {
            var request = httpContext.Request;
            var reader = new StreamReader(request.Body);
            string body = await reader.ReadToEndAsync();
            
        }
        context.Succeed(requirement);
    }
}