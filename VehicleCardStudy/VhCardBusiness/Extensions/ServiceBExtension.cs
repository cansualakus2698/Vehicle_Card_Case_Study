using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhCardBusiness.Abstract;
using VhCardBusiness.Concrete;
using VhCardDataAccess.Extensions;

namespace VhCardBusiness.Extensions
{
    public static class ServiceBExtension
    {
        public static IServiceCollection AddBusinessDependencies(this IServiceCollection services)
        {
            services.AddDADependencies();
            services.AddScoped<IVehiclesTypeService, VehiclesTypeManager>();
            services.AddScoped<IVehicleService, VehicleManager>();

            return services;
        }
    }
}
