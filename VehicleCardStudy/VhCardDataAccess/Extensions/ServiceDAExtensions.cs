using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VhCardDataAccess.Abstract;
using VhCardDataAccess.Concrete;

namespace VhCardDataAccess.Extensions
{
    public static class ServiceDAExtensions
    {
        public static IServiceCollection AddDADependencies(this IServiceCollection services)
        {
            services.AddScoped<IVehiclesTypeDal, VehiclesTypeDal>();
            services.AddScoped<IVehicleDal, VehicleDal>();
            return services;
        }
    }
}
