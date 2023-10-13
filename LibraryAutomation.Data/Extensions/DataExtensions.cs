using LibraryAutomation.Data.Context;
using LibraryAutomation.Data.Repositories.Abstracts;
using LibraryAutomation.Data.Repositories.Concretes;
using LibraryAutomation.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Data.Extensions
{
    public static class DataExtensions
    {
        public static IServiceCollection LoadDataExtension( this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddDbContext<LibraryDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("Local")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
