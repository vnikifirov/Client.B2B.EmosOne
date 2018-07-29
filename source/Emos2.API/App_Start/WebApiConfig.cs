using Emos2.API.Registration;
using Emos2.Factory;
using FluentValidation.WebApi;
using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Emos2.API.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, IAppBuilder appBuilder)
        {
            // Setting Web API configuration and services
            Assembly webApiAssembly = typeof(Emos2.API.Emos2ApiApplication).Assembly;
            Autofac.Module webApiModule = new Emos2ApiRegistrationModule();
            ServiceFactoryBuilder.SetWebApiDependenciesAndOWIN(webApiAssembly, config, appBuilder, webApiModule);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Seeting CamelCaseNamesContractResolver
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // FluentValidation API settings
            FluentValidationModelValidatorProvider.Configure(config);

            // Seting global exception handling
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            config.Services.Add(typeof(IExceptionLogger), new UnhandledExceptionLogger());
        }
    }
}