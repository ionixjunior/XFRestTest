using Autofac;
using Core.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core.ViewModels
{
	public class ContactDetailViewModel : BaseViewModel
	{
		public ICommand SaveCommand { get; private set; }

		public ICommand DeleteCommand { get; private set; }

		private IContactService _contactService;
		private IContactService ContactService
		{
			get
			{
				using (var scope = AppContainer.Container.BeginLifetimeScope())
				{
					_contactService = scope.Resolve<IContactService>();
				}

				return _contactService;
			}
		}

		private ContactModel _contact { get; set; }

		public ContactModel Contact
		{
			get { return _contact; }
			set 
			{
				_contact = value;
				INotifyPropertyChanged ();
			}
		}

		public ContactDetailViewModel()
		{
			SaveCommand = new Command (async () => await SaveExec());
			DeleteCommand = new Command (async () => await DeleteExec());
		}

		public async void LoadData(string id)
		{
			if (id == null) 
			{
				Contact = new ContactModel ();
			} 
			else 
			{
				Contact = await ContactService.Get (id);
			}
		}

		private async Task SaveExec()
		{
			if (Contact.Id == null) 
			{
				await ContactService.Post (Contact);
				await Application.Current.MainPage.Navigation.PopAsync ();
			} 
			else 
			{
				await ContactService.Put (Contact.Id, Contact);
				await Application.Current.MainPage.Navigation.PopAsync ();
			}
		}

		private async Task DeleteExec()
		{
			await ContactService.Delete (Contact.Id);
			await Application.Current.MainPage.Navigation.PopAsync ();
		}
	}
}

