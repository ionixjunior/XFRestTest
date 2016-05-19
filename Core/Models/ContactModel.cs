using System;
using Newtonsoft.Json;

namespace Core.Models
{
	public class ContactModel
	{
		[JsonProperty("_id")]
		public string Id { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }
	}
}

