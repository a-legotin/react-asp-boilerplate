using Autofac;
using Identity.Core.Interfaces.Gateways.Repositories;
using Identity.Core.Interfaces.Services;
using Identity.Infrastructure.Auth;
using Identity.Infrastructure.Data.Repositories;
using Identity.Infrastructure.Interfaces;

namespace Identity.Infrastructure.DI
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<JwtFactory>().As<IJwtFactory>();
            builder.RegisterType<JwtTokenHandler>().As<IJwtTokenHandler>();
            builder.RegisterType<TokenFactory>().As<ITokenFactory>();
            builder.RegisterType<JwtTokenValidator>().As<IJwtTokenValidator>();
        }
    }
}
