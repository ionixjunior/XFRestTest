using Core.Models;
using System.Threading.Tasks;
using Core.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Autofac;

namespace Core.ViewModels
{
	public class ContactViewModel : BaseViewModel
	{
		public ICommand DeleteCommand { get; private set; }

		private ObservableCollection<ContactModel> _contacts;
		public ObservableCollection<ContactModel> Contacts
		{
			get { return _contacts; }
			set { _contacts = value; INotifyPropertyChanged (); }
		}

		private ContactService _contactService;
		private ContactService ContactService
		{
			get
			{
				using (var scope = AppContainer.Container.BeginLifetimeScope())
				{
					_contactService = scope.Resolve<ContactService>();
				}

				return _contactService;
			}
		}

		public ContactViewModel()
		{
			DeleteCommand = new Command<ContactModel>(async (model) => await DeleteExec(model));
		}

		private async Task DeleteExec(ContactModel model)
		{
			await ContactService.Delete(model.Id);
			Contacts.Remove(model);
		}

		public async void LoadData()
		{
			Contacts = new ObservableCollection<ContactModel>(await ContactService.Get ());
		}
	}
}

