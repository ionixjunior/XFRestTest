using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Services
{
	public class ContactService : BaseService
	{
		private string _endPoint = "/contacts";

		public async Task<IList<ContactModel>> Get()
		{
			IList<ContactModel> response = new List<ContactModel>();

			try
			{
				response = await base.Get<ContactModel>(_endPoint);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e.Message);
			}

			return response;
		}

		public async Task<ContactModel> Get(string id)
		{
			ContactModel response = new ContactModel();

			try
			{
				response = await base.Get<ContactModel>(_endPoint, id);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e.Message);
			}

			return response;
		}

		public async Task<ContactModel> Post(ContactModel contactModel)
		{
			ContactModel response = new ContactModel();

			try
			{
				response = await base.Post<ContactModel>(_endPoint, contactModel);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e.Message);
			}

			return response;
		}

		public async Task<ContactModel> Put(string id, ContactModel contactModel)
		{
			ContactModel response = new ContactModel();

			try
			{
				response = await base.Put(_endPoint, id, contactModel);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e.Message);
			}

			return response;
		}

		public async Task<bool> Delete(string id)
		{
			bool response = false;

			try
			{
				response = await base.Delete(_endPoint, id);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e.Message);
			}

			return response;
		}
	}
}

