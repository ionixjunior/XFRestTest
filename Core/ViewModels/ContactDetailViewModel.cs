using System;
using Core.Models;
using Core.Services;

namespace Core.ViewModels
{
	public class ContactDetailViewModel : BaseViewModel
	{
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

		public async void LoadData(string id)
		{
			ContactService contactService = new ContactService ();
			Contact = await contactService.Get (id);
		}
	}
}

