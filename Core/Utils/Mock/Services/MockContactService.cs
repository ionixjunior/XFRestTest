using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;

namespace Core.Utils.Mock.Services
{
	public class MockContactService : IContactService
	{
		public Task<bool> Delete(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<IList<ContactModel>> Get()
		{
			IList<ContactModel> result = null;

			await Task.Run(() =>
			{
				result = new List<ContactModel>()
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
			});

			return result;
		}

		public Task<ContactModel> Get(string id)
		{
			throw new NotImplementedException();
		}

		public Task<ContactModel> Post(ContactModel contactModel)
		{
			throw new NotImplementedException();
		}

		public Task<ContactModel> Put(string id, ContactModel contactModel)
		{
			throw new NotImplementedException();
		}
	}
}

