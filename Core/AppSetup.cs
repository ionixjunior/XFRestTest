using Autofac;
using Core.Enums;
using Core.Interfaces;
using Core.Services;
using Core.Utils.Mock.Services;

namespace Core
{
	public class AppSetup
	{
		public IContainer CreateContainer()
		{
			var containerBuilder = new ContainerBuilder();

			if (AppEnvironment.Environment == EnvironmentEnum.Test)
			{
				RegisterTestDependencies(containerBuilder);
			}
			else
			{
				RegisterDependencies(containerBuilder);
			}

			return containerBuilder.Build();
		}

		protected void RegisterTestDependencies(ContainerBuilder cb)
		{
			cb.RegisterType<MockContactService>().As<IContactService>().SingleInstance();
		}

		protected void RegisterDependencies(ContainerBuilder cb)
		{
			cb.RegisterType<ContactService>().As<IContactService>().SingleInstance();
		}
	}
}

