using Project.Core.Interfaces.IRepositories;
using Project.Core.Interfaces.IServices;
using Project.Core.Services;
using Project.Infrastructure.Repositories;


namespace Project.API.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            #region Services

            services.AddScoped<IMealService, MealService>();

            #endregion

            #region Repositories

            services.AddTransient<IMealRepository, MealRepository>();

            #endregion

            return services;
        }
    }
}