using System;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

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
			get { return (_contactService == null) ? _contactService = new ContactService() : _contactService; }
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

