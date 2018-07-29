using Autofac;
using Emos2.API.Models.Users.Login;
using Emos2.API.Validations;
using Emos2.API.Validations.Users.Login;
using FluentValidation;
using FluentValidation.WebApi;
using System.Web.Http.Validation;

namespace Emos2.API.Registration
{
    public class Emos2ApiRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FluentValidationModelValidatorProvider>().As<ModelValidatorProvider>();
            builder.RegisterType<ValidatorFactory>().As<IValidatorFactory>();

            builder.RegisterType<LoginValidator>().Keyed<IValidator>(typeof(IValidator<LoginModel>)).As<IValidator>();
            builder.RegisterType<LoginRefreshValidator>().Keyed<IValidator>(typeof(IValidator<LoginRefreshModel>)).As<IValidator>();
            //builder.RegisterType<UserCreateValidator>().Keyed<IValidator>(typeof(IValidator<UserCreateModel>)).As<IValidator>();
            //builder.RegisterType<UserUpdateValidator>().Keyed<IValidator>(typeof(IValidator<UserUpdateModel>)).As<IValidator>();
        }
    }
}