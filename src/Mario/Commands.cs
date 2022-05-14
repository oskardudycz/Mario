using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Mario;

public static class Commands
{
    public static RouteHandlerBuilder MapCommand(
        this IEndpointRouteBuilder endpoints,
        string pattern,
        Delegate handler
    )
    {

        return endpoints.MapPost(pattern, handler);
    }
}
