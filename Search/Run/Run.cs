using Microsoft.Extensions.DependencyInjection;
using Search.Service;
using Search.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Run
{
    public class Run
    {
        public static async Task Main(string[] args)
        {
            // Setup DI container
            var serviceProvider = new ServiceCollection()
                .AddTransient<IService, Search.Service.Service>() // Register Service
                .BuildServiceProvider();

            // Resolve and run the service
            var service = serviceProvider.GetRequiredService<IService>();
            await service.RunBinaryTree();
        }
    }
}
