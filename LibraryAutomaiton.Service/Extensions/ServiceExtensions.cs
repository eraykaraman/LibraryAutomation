using LibraryAutomaiton.Service.Services.Abstracts;
using LibraryAutomaiton.Service.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryAutomaiton.Service.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServiceExtension(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IRentService, RentService>();
            services.AddScoped<IExceptionService, ExceptionService>();
            return services;
        }
    }
}
