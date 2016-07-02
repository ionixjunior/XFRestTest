using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces
{
	public interface IContactService
	{
		Task<IList<ContactModel>> Get();
		Task<ContactModel> Get(string id);
		Task<ContactModel> Post(ContactModel contactModel);
		Task<ContactModel> Put(string id, ContactModel contactModel);
		Task<bool> Delete(string id);
	}
}

