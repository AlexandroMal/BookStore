using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void InjectDatabaseServices(this IServiceCollection services)
        {
            services.AddDatabase();
        }

        public static void AddDatabase(this IServiceCollection services)
        {
            //add database here
        }
    }
}
