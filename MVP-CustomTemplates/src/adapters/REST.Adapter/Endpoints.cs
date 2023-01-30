using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
#if (RESTWithMongoDB)
using MongoDB.Adapter;
#endif
#if (RESTWithSQL)
using SQL.Adapter;
#endif

namespace REST.Adapter
{
    public class Endpoints
    {
        public static void DefineEndpoints<T>(IEndpointRouteBuilder app, string Tag)
        {
            app.MapGet(RouteConstants.BaseRoute, GetAllAsync)
                       .WithName("GetBooks")
                       .Produces<IEnumerable<T>>(200)
                       .WithTags(Tag);
        }

        internal static async Task<IResult> GetAllAsync(string? searchTerm)
        {
            await Task.CompletedTask;
            return Results.Ok();
        }

        public static IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration)
        {
#if (RESTWithMongoDB)
            services.RegisterMongoDb(configuration);
#endif

#if (RESTWithSQL)
            services.RegisterSql(configuration);
#endif

            return services;
        }


    }
}
