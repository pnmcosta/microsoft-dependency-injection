using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Specification;

namespace Unity.Microsoft.DependencyInjection.Tests
{
    public class UnityTests : DependencyInjectionSpecificationTests
    {
        readonly IUnityContainer container = new UnityContainer();
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            return container.BuildServiceProvider(serviceCollection);
        }
    }
}