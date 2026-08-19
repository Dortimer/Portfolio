using Microsoft.EntityFrameworkCore;
using Portfolio.Core.DTO;
using Portfolio.Core.Mappings;
using Portfolio.Data.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data.Services
{
	public interface IResumeService
	{
		Task<Resume> GetResumeAsync();
	}

	public class ResumeService : IResumeService
	{
		private readonly PortfolioDbContext _context;

		public ResumeService(PortfolioDbContext context) 
		{
			_context = context;
		}

		public async Task<Resume> GetResumeAsync() 
		{
			var positions = await _context.Position
				.AsNoTracking()
				.Include(x => x.Experiences)
				.Include(x => x.Qualifications)
				.Include(x => x.Company)
				.Include(x => x.Company.CompanyContact)
				.ToListAsync();

			var education = await _context.Education
				.AsNoTracking()
				.Include(x => x.SchoolContact)
				.ToListAsync();

			return new Resume
			{
				Education = education.Select(x => x.ToDto()).ToList(),
				Positions = positions.Select(x => x.ToDto()).ToList()
			};
		}
	}
}
