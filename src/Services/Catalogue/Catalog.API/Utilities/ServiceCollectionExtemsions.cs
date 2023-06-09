using Catalog.API.Data;
using Catalog.API.Repositories;
using System.Runtime.CompilerServices;

namespace Catalog.API.Utilities
{
    public static class ServiceCollectionExtemsions
    {
        public static void RegisterData(this IServiceCollection services)
        {
            services.AddScoped<ICatalogueContext, CatalogueContext>();
            services.AddScoped<IProductRepository, ProductRepository>();

        }

        public static void ConfigureEnvironment(this IWebHostEnvironment env, WebApplication app)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
        }
    }


}
