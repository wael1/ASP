using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DI_01.Services
{
    public class B: IB
    {
        //public B(ILogger<B> logger, IA serviceA)
        //{
            
        //}
        public B(ILogger<B> logger, IServiceProvider serviceProvider)

        {
            using var scope = serviceProvider.CreateScope();
            var serviceA = scope.ServiceProvider.GetRequiredService<IA>();

        }
    }
}
