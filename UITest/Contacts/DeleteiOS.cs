using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace UITest.Contacts
{
	[TestFixture(Platform.iOS)]
	public class DeleteiOS
	{
		IApp app;
		Platform platform;

		public DeleteiOS(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void DeleteWithSwipe()
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


			// Exclusão com swipe
			app.SwipeRightToLeft(firstName);
			app.Tap(e => e.Text("Apagar"));
		}
	}
}

