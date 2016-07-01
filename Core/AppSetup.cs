using Autofac;
using Core.Services;

namespace Core
{
	public class AppSetup
	{
		public IContainer CreateContainer()
		{
			var containerBuilder = new ContainerBuilder();
			RegisterDependencies(containerBuilder);
			return containerBuilder.Build();
		}

		protected virtual void RegisterDependencies(ContainerBuilder cb)
		{
			cb.RegisterType<ContactService>().SingleInstance();
		}
	}
}

