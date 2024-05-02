using Microsoft.Extensions.DependencyInjection;
using Search.Service;



var serviceProvider = new ServiceCollection()
    .AddTransient<IService, Search.Service.Service>() // Register Service
    .BuildServiceProvider();

// Resolve and run the service
var service = serviceProvider.GetRequiredService<IService>();
//await service.RunBinaryTree();
await service.RunBinarySearch();
await service.RunParallelSearch();