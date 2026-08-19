using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

// todo - Experience and Qualification could probably be consolidated and include a type? Separate tables are more explicit with the difference though
namespace Portfolio.Core.Entities
{
	public class Experience
	{
		public Guid Id { get; set; }
		public Guid PositionId { get; set; }

		[MaxLength]
		public string Description { get; set; }
	}
}
