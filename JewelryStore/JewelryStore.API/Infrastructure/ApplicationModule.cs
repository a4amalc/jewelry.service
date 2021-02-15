using Autofac;
using JewelryStore.Business.Services;
using JewelryStore.Data.Repository;

namespace JewelryStore.API.Infrastructure.AutofacModules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Repository Registration
            builder.RegisterType<AuthRepository>()
             .As<IAuthRepository>()
             .InstancePerLifetimeScope();


            #endregion

            #region Queries Registration


            builder.RegisterType<AuthService>()
           .As<IAuthService>()
           .InstancePerLifetimeScope();
            #endregion
        }
    }

}
