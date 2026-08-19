using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Entities
{
	public class Education
	{
		public Guid Id { get; set; }
		public string DegreeTitle { get; set; }
		public string SchoolName { get; set; }
		public Guid SchoolContactId { get; set; }
		public Contact SchoolContact { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
