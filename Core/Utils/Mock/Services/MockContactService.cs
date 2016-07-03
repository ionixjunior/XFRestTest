using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;

namespace Core.Utils.Mock.Services
{
	public class MockContactService : IContactService
	{
		private IList<ContactModel> Contacts { get; set; }

		public MockContactService()
		{
			Contacts = new List<ContactModel>()
			{
				new ContactModel() {
					Id = "1", FirstName = "Robert",
					LastName = "Taylor", Email = "robert.taylor@gmail.com",
					CreatedAt = DateTime.Now
				},
				new ContactModel() {
					Id = "2", FirstName = "Ana",
					LastName = "Berner", Email = "ana.berner@gmail.com",
					CreatedAt = DateTime.Now
				}
			};
		}

		public async Task<bool> Delete(string id)
		{
			bool result = false;

			await Task.Run(() =>
			{
				ContactModel contactModel = Contacts.SingleOrDefault(m => m.Id == id);
				if (contactModel != null)
				{
					Contacts.Remove(contactModel);
					result = true;
				}
			});

			return result;
		}

		public async Task<IList<ContactModel>> Get()
		{
			IList<ContactModel> result = null;

			await Task.Run(() =>
			{
				result = Contacts;
			});

			return result;
		}

		public async Task<ContactModel> Get(string id)
		{
			ContactModel contactModel = null;

			await Task.Run(() =>
			{
				contactModel = Contacts.SingleOrDefault(m => m.Id == id);
			});

			return contactModel;
		}

		public async Task<ContactModel> Post(ContactModel contactModel)
		{
			await Task.Run(() =>
			{
				contactModel.Id = Guid.NewGuid().ToString();
				Contacts.Add(contactModel);
			});

			return contactModel;
		}

		public async Task<ContactModel> Put(string id, ContactModel contactModel)
		{
			ContactModel originalContactModel = null;

			await Task.Run(() =>
			{
				originalContactModel = Contacts.SingleOrDefault(m => m.Id == id);
				originalContactModel.FirstName = contactModel.FirstName;
				originalContactModel.LastName = contactModel.LastName;
				originalContactModel.Email = contactModel.Email;
				originalContactModel.CreatedAt = contactModel.CreatedAt;
			});

			return originalContactModel;
		}
	}
}

