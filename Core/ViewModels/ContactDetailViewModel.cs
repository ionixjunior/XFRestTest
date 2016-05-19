using System;
using Core.Models;
using Core.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace Core.ViewModels
{
	public class ContactDetailViewModel : BaseViewModel
	{
		public ICommand SaveCommand { get; private set; }

		private ContactService _contactService { get; set; }

		private ContactService ContactService
		{
			get 
			{
				if (_contactService == null) 
				{
					_contactService = new ContactService ();
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
		}
	}
}

