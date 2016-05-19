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
			return await base.Get<ContactModel> (_endPoint);
		}

		public async Task<ContactModel> Get(string id)
		{
			return await base.Get<ContactModel> (_endPoint, id);
		}
	}
}

