using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.DTO
{
	public class Contact
	{
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public string State { get; set; }
		public string City { get; set; }
		public string ZIP { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
	}
}
