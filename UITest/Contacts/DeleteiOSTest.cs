using NUnit.Framework;
using Xamarin.UITest;

namespace UITest.Contacts
{
	[TestFixture(Platform.iOS)]
	public class DeleteiOSTest : BaseTest
	{
		public DeleteiOSTest(Platform platform) : base (platform) { }

		[Test]
		public void DeleteWithSwipe()
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

			// Exclusão com swipe
			// TODO: analisar swipePercentage; necessário quando inserimos um contato e em seguida tentamos remove-lo.
			app.Screenshot("Lista dos contatos - após cadastro");
			app.SwipeRightToLeft(firstName, swipePercentage: 0.9);
			app.Screenshot("Swipe para apagar");
			app.Tap(e => e.Text("Apagar"));
			app.Screenshot("Contato apagado");
		}
	}
}

