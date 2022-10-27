using Aplication.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;
using Persistance.Reposotories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersisteceService(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppliDbContext>(d => d.UseSqlServer(configuration.GetConnectionString("BookSiteConnectionString")));
            services.AddTransient<Ibook, BookReposotory>();

        }
    }
}
