using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace ProductApiWithVersions.Extensions
{
    public static class VersioningConfiExtension
    {
        public static void AddVersioningConfig(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
                //options.ApiVersionReader = new HeaderApiVersionReader("X-version"); // odczyt wersji z headera zapytania

                //options.ApiVersionReader = ApiVersionReader.Combine(
                //    new HeaderApiVersionReader("X-version"), // odczyt wersji z headera zapytania
                //    new QueryStringApiVersionReader("api-version"));  //odczyt z query string https://localhost:5001/api/Product?api-version=1.0
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
        }
    }
}
