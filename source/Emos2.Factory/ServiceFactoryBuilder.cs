using Autofac;
using Autofac.Integration.WebApi;
using Emos2.Domain.Security.Configurations;
using Emos2.Infrastructure.Entities;
using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Entities.DatabaseEmos1;
using Emos2.Infrastructure.Repositories;
using Emos2.Infrastructure.Services;
using Emos2.Repository.Entities.Database;
using Emos2.Repository.Repositories;
using Emos2.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Emos2.Factory
{
    public static class ServiceFactoryBuilder
    {
        public static IContainer container;

        public static void SetWebApiDependenciesAndOWIN(System.Reflection.Assembly webApiAssembly, HttpConfiguration httpConfiguration, IAppBuilder appBuilder, Module webApiModule)
        {
            // Register components
            ContainerBuilder containerBuilder = new ContainerBuilder();

            // Register dependencies in controllers
            containerBuilder.RegisterApiControllers(webApiAssembly);

            // Register database entities context
            containerBuilder.Register(dbContext => new Emos1Context()).As<IContextEmos1>().InstancePerLifetimeScope();
            containerBuilder.Register(dbContext => new ESRContext()).As<IContextESR>().InstancePerDependency();

            // Register security implementations
            // Users
            ////containerBuilder.RegisterType<ApplicationUserStore>().As<IUserStore<ApplicationUser>>().InstancePerLifetimeScope();
            ////containerBuilder.RegisterType<ApplicationUserManager>().AsSelf();
            ////containerBuilder.RegisterType<ApplicationSignInManager>().AsSelf();
            ////// Roles
            ////containerBuilder.RegisterType<ApplicationRoleStore>().As<IRoleStore<ApplicationRole, string>>();
            ////containerBuilder.RegisterType<ApplicationRoleManager>().AsSelf();

           
            // Register repositories ESR
            containerBuilder.RegisterType<ESRRepository<CEMUser>>().As<IRepositoryESR<CEMUser>>();
            containerBuilder.RegisterType<ESRRepository<UserSystemAction>>().As<IRepositoryESR<UserSystemAction>>();
            containerBuilder.RegisterType<ESRRepository<Event>>().As<IRepositoryESR<Event>>();

            // Register repositories EMOS1
            containerBuilder.RegisterType<Emos1Repository<Client>>().As<IRepositoryEmos1<Client>>().InstancePerLifetimeScope();


            // Register ESR services
            containerBuilder.RegisterType<LoginService>().As<ILoginService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<UserPermissionService>().As<IUserPermissionService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<EventService>().As<IEventService>().InstancePerLifetimeScope();

            // Register EMOS1 services
            containerBuilder.RegisterType<ClientService>().As<IClientService>().InstancePerLifetimeScope();

            // Register WebApiModule
            containerBuilder.RegisterModule(webApiModule);

            // Register OWIN functionalities
            containerBuilder.Register<IAuthenticationManager>(c => HttpContext.Current.GetOwinContext().Authentication);

            // Setting DependencyResolver
              container = containerBuilder.Build();
            AutofacWebApiDependencyResolver dependencyResolver = new AutofacWebApiDependencyResolver(container);
            httpConfiguration.DependencyResolver = dependencyResolver;

            // Create Per OWIN Context
            //appBuilder.CreatePerOwinContext<IdentityDbContext<ApplicationUser>>(Emos2EntitiesContext.Create);

            // Setting OWIN WebAPIconfigurations, token generation
            appBuilder.UseOAuthAuthorizationServer(AuthenticationConfig.GetTokenAuthenticationOptions(container));
            appBuilder.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            // Registering Owin with Dependecy Injection framework
            appBuilder.UseAutofacMiddleware(container);
            appBuilder.UseAutofacWebApi(httpConfiguration);

            // Enabling OWIN CORS
            appBuilder.UseCors(CorsOptions.AllowAll);

            // Configures Web API to run on top of OWIN
            appBuilder.UseWebApi(httpConfiguration);
        }

    }
}
