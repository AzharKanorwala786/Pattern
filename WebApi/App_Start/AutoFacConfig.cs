namespace WebApi.App_Start
{
    #region Usings
    using System.Reflection;
    using System.Web.Http;
    using Autofac;
    using Autofac.Integration.WebApi;
    using Infrastructure.Interfaces;
    using Infrastructure.DBFactory;
    using Infrastructure.Repositories;
    using Infrastructure.UOW;
    using Service.Services;
    #endregion

    public class AutoFacConfig
    {
        public static void Initialize(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(RegisterServices());
        }

        private static IContainer RegisterServices()
        {
            var builder = new ContainerBuilder();

            var container = builder.Build();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<DBFactory>().As<IDbFactory>();

            builder.RegisterAssemblyTypes(typeof(ProductRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(ProductService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            return container;
        }
    }
}