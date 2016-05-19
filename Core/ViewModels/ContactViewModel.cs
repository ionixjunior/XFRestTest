using System;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Services;

namespace Core.ViewModels
{
	public class ContactViewModel : BaseViewModel
	{
		private IList<ContactModel> _contacts { get; set; }

		public IList<ContactModel> Contacts
		{
			get { return _contacts; }
			set 
			{
				_contacts = value;
				INotifyPropertyChanged ();
			}
		}

		public async void LoadData()
		{
			ContactService contactService = new ContactService ();
			Contacts = await contactService.Get ();
		}
	}
}

