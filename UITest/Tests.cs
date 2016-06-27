using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
	//[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		//[Test]
		//public void AppLaunches()
		//{
		//	app.Screenshot("First screen.");
		//}

		[Test]
		public void BasicFlow()
		{
			string firstName = "John";
			string lastName = "Smith";
			string email = "john@smith.com";

			// Cadastro
			app.Tap(e => e.Id("tbiAdd"));

			app.Tap(e => e.Text("Nome"));
			app.EnterText(firstName);

			app.Tap(e => e.Text("Sobrenome"));
			app.EnterText(lastName);

			app.Tap(e => e.Text("Email"));
			app.EnterText(email);

			app.Tap(e => e.Id("tbiSave"));


			// Edição
			app.Tap(e => e.Text(firstName));

			firstName = "Sr. John";
			app.Tap(e => e.Text("Nome"));
			app.ClearText();
			app.EnterText(firstName);

			lastName = "A. Smith";
			app.Tap(e => e.Text("Sobrenome"));
			app.ClearText();
			app.EnterText(lastName);

			email = "john@asmith.com";
			app.Tap(e => e.Text("Email"));
			app.ClearText();
			app.EnterText(email);
			app.Tap(e => e.Id("tbiSave"));


			// Exclusão
			app.Tap(e => e.Text(firstName));

			app.Tap(e => e.Id("btnDelete"));
		}
	}
}

