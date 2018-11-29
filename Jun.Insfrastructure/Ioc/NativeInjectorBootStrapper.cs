using Jun.Insfrastructure.Context;
using Jun.Insfrastructure.IRepository;
using Jun.Insfrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jun.Insfrastructure.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IsDbContext>();

            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
