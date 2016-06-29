using NUnit.Framework;
using Xamarin.UITest;

namespace UITest.Contacts
{
	[TestFixture(Platform.Android)]
	public class DeleteAndroidTest : BaseTest
	{
		public DeleteAndroidTest(Platform platform) : base(platform) { }

		[Test]
		public void DeleteWithTouchAndHold()
		{
			string firstName = "John";
			string lastName = "Smith";
			string email = "john@smith.com";

			// Cadastro
			app.Screenshot("Lista dos contatos - início");
			app.Tap(e => e.Text("Adicionar"));

			app.Tap(e => e.Marked("etrFirstName"));
			app.EnterText(firstName);
			app.Tap(e => e.Marked("etrLastName"));
			app.EnterText(lastName);
			app.Tap(e => e.Marked("etrEmail"));
			app.EnterText(email);
			app.Screenshot("Campos preenchidos");
			app.Tap(e => e.Text("Salvar"));

			// Exclusão
			app.Screenshot("Lista dos contatos - após cadastro");
			app.TouchAndHold(firstName);
			app.Screenshot("Touch and Hold para apagar");
			app.Tap(e => e.Text("Apagar"));
			app.Screenshot("Contato apagado");
		}
	}
}

