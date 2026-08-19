using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Mappings
{
	// todo - considering breaking mappings out into separate files
	public static class Mappings
	{
		// education
		public static DTO.Education ToDto(this Entities.Education entity)
		{
			return new DTO.Education
			{
				DegreeTitle = entity.DegreeTitle,
				SchoolName = entity.SchoolName,
				SchoolContact = entity.SchoolContact.ToDto(),
				StartDate = entity.StartDate,
				EndDate = entity.EndDate
			};
		}

		// contact
		public static DTO.Contact ToDto(this Entities.Contact entity)
		{
			return new DTO.Contact
			{
				AddressLine1 = entity.AddressLine1,
				AddressLine2 = entity.AddressLine2,
				State = entity.State,
				City = entity.City,
				ZIP = entity.ZIP,
				PhoneNumber = entity.PhoneNumber,
				Email = entity.Email
			};
		}

		// company
		public static DTO.Company ToDto(this Entities.Company entity)
		{
			return new DTO.Company
			{
				CompanyContact = entity.CompanyContact.ToDto(),
				CompanyName = entity.CompanyName
			};
		}

		// position
		public static DTO.Position ToDto(this Entities.Position entity)
		{
			return new DTO.Position
			{
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Title = entity.Title,
				Company = entity.Company.ToDto(),
				Qualifications = entity.Qualifications.Select(x => x.ToDto()).ToList(),
				Experiences = entity.Experiences.Select(x => x.ToDto()).ToList()
			};
		}

		// qualification
		public static DTO.Qualification ToDto(this Entities.Qualification entity)
		{
			return new DTO.Qualification
			{
				Description = entity.Description
			};
		}

		// experience
		public static DTO.Experience ToDto(this Entities.Experience entity) 
		{ 
			return new DTO.Experience 
			{ 
				Description = entity.Description 
			};
		}
	}
}
