using NUnit.Framework;
using Xamarin.UITest;

namespace UITest
{
	public abstract class BaseTest
	{
		protected IApp app;
		protected Platform platform;

		protected BaseTest(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}
	}
}

