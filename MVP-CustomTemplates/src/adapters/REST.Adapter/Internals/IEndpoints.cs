using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Adapter.Internals
{
    public interface IEndpoints
    {
        public static abstract void DefineEndpoints(IEndpointRouteBuilder app);

        public static abstract void AddServices(IServiceCollection services, IConfiguration configuration);
    }
}
