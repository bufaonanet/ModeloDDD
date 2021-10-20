using Autofac;

namespace RestApiModeloDDD.Infrastructure.CrossCutting
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}