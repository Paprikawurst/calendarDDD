using System;
using Autofac;
using ProductsDDD.Application;
using ProductsDDD.Application.Contracts;
using ProductsDDD.Infrastructure.Contracts;
using ProductsDDD.Infrastructure.Repositories;

namespace ProductsDDD.IoC
{
    public static class IocContainer
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRepository>().As<IProductRepository>().SingleInstance();
            builder.RegisterType<ProductService>().As<IProductService>().SingleInstance();
            //builder.RegisterType<ProductService2>().As<IProductService>().SingleInstance();
        }
    }
}
