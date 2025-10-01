using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension method to add core to the dpendency injection Container
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            // use: Add sservices to the IoC container
            // core services often include data access, caching and other low-level components

            return services;
        }
    }
}
