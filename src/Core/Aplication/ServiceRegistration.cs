using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Aplication
{
    public static class ServiceRegistration
    {
        public static void AddAplicationRegistration(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assm);
            services.AddMediatR(assm);
        }
    }
}
