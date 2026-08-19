using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Entities
{
	public class Company
	{
		public Guid Id { get; set; }
		public string CompanyName { get; set; }
		public Guid CompanyContactId { get; set; }
		public Contact CompanyContact { get; set; }
	}
}
