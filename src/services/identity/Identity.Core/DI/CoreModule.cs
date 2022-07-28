using Autofac;
using Identity.Core.Interfaces.UseCases;
using Identity.Core.UseCases;

namespace Identity.Core.DI
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegisterUserUseCase>().As<IRegisterUserUseCase>();
            builder.RegisterType<LoginUseCase>().As<ILoginUseCase>();
            builder.RegisterType<ExchangeRefreshTokenUseCase>().As<IExchangeRefreshTokenUseCase>();
        }
    }
}
