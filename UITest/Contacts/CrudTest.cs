using NUnit.Framework;
using Xamarin.UITest;

namespace UITest.Contacts
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class CrudTest : BaseTest
	{
		public CrudTest(Platform platform) : base(platform) { }

		[Test]
		public void BasicFlow()
		{
			//string firstName = "John";
			//string lastName = "Smith";
			//string email = "john@smith.com";

			app.Repl();


			//// Cadastro
			////app.Tap(e => e.Id("tbiAdd"));//problemas no android
			//app.Tap(e => e.Text("Adicionar"));

			//app.EnterText(e => e.Marked("etrFirstName"), firstName);
			//app.EnterText(e => e.Marked("etrLastName"), lastName);
			//app.EnterText(e => e.Marked("etrEmail"), email);

			////app.Tap(e => e.Id("tbiSave"));//problemas no android
			//app.Tap(e => e.Text("Salvar"));


			//// Edição
			//app.Tap(e => e.Text(firstName));

			//firstName = "Sr. John";
			//app.Tap(e => e.Marked("etrFirstName"));
			//app.ClearText();
			//app.EnterText(firstName);

			//lastName = "A. Smith";
			//app.Tap(e => e.Marked("etrLastName"));
			//app.ClearText();
			//app.EnterText(lastName);

			//email = "john@asmith.com";
			//app.Tap(e => e.Marked("etrEmail"));
			//app.ClearText();
			//app.EnterText(email);
			//app.Tap(e => e.Text("Salvar"));


			//// Exclusão
			//app.Tap(e => e.Text(firstName));

			////app.Tap(e => e.Id("btnDelete"));//problemas no android
			//app.Tap(e => e.Text("Apagar"));
		}
	}
}

