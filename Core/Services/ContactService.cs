using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Services
{
	public class ContactService : BaseService
	{
		public async Task<IList<ContactModel>> Get()
		{
			return await base.Get<ContactModel> ("/contacts");
		}
	}
}

