using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.DTO
{
	public class Position
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Title { get; set; }
		public Company Company { get; set; }
		public List<Qualification> Qualifications { get; set; }
		public List<Experience> Experiences { get; set; }
	}
}
