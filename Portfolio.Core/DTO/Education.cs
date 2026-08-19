using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.DTO
{
	public class Education
	{
		public string DegreeTitle { get; set; }
		public string SchoolName { get; set; }
		public Contact SchoolContact { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
