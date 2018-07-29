using Autofac;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emos2.API.Validations
{
    public class ValidatorFactory : ValidatorFactoryBase
    {
        private readonly IComponentContext container;

        public ValidatorFactory(IComponentContext container)
        {
            this.container = container;
        }


        public override IValidator CreateInstance(Type validatorType)
        {
            IValidator validator = this.container.ResolveOptionalKeyed<IValidator>(validatorType);

            return validator;
        }
    }
}