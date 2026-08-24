using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.DTO
{
	public class Company
	{
		public string CompanyName { get; set; } = string.Empty;
		public Contact? CompanyContact { get; set; }
	}
}
