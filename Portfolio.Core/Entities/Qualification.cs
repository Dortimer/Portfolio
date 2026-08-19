using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Entities
{
	public class Qualification
	{
		public Guid Id { get; set; }
		public Guid PositionId { get; set; }
		public string Description { get; set; }
	}
}
