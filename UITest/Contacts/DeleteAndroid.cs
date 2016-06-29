using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace UITest.Contacts
{
	[TestFixture(Platform.Android)]
	public class DeleteAndroid
	{
		IApp app;
		Platform platform;

		public DeleteAndroid(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void DeleteWithLongPress()
		{
			string firstName = "John";
			string lastName = "Smith";
			string email = "john@smith.com";

			// Cadastro
			app.Tap(e => e.Text("Adicionar"));

			app.Tap(e => e.Marked("etrFirstName"));
			app.EnterText(firstName);
			app.Tap(e => e.Marked("etrLastName"));
			app.EnterText(lastName);
			app.Tap(e => e.Marked("etrEmail"));
			app.EnterText(email);
			app.Tap(e => e.Text("Salvar"));

			// Exclusão
			app.TouchAndHold(firstName);
			app.Tap(e => e.Text("Apagar"));
		}
	}
}

