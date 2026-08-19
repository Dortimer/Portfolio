using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;

namespace Portfolio.Data.Data
{
	public class PortfolioDbContext: DbContext
	{
		public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Education init
			var schoolContactId = Guid.Parse("01010101-0101-0101-0101-010101010101");
			var educationId = Guid.Parse("10101010-1010-1010-1010-101010101010");

			modelBuilder.Entity<Contact>().HasData(
				new Contact
				{
					Id = schoolContactId,
					AddressLine1 = "",
					AddressLine2 = "",
					State = "WI",
					City = "La Crosse",
					ZIP = "54601",
					PhoneNumber = "",
					Email = ""
				}	
			);

			modelBuilder.Entity<Education>().HasData(
				new Education
				{
					Id = educationId,
					DegreeTitle = "B.S. Software Application Development",
					SchoolName = "Globe University",
					StartDate = new DateTime(2011, 10, 1),
					EndDate = new DateTime(2015, 9, 1),
					SchoolContactId = schoolContactId
				}	
			);

			// S&S Contact
			var ssContactId = Guid.Parse("33333333-3333-3333-3333-333313333933");
			modelBuilder.Entity<Contact>().HasData(
				new Contact
				{
					Id = ssContactId,
					AddressLine1 = "",
					AddressLine2 = "",
					State = "IL",
					City = "Bolingbrook",
					ZIP = "60440",
					PhoneNumber = "",
					Email = ""
				}
			);

			// S&S Company
			var ssCompanyId = Guid.Parse("22222222-2222-2222-2222-222222222222");
			modelBuilder.Entity<Company>().HasData(
				new Company
				{
					Id = ssCompanyId,
					CompanyName = "S&S Activewear",
					CompanyContactId = ssContactId
				}
			);

			// S&S Position
			var ssPositionId = Guid.Parse("11111111-1111-1111-1111-111111111112");
			modelBuilder.Entity<Position>().HasData(
				new Position
				{
					Id = ssPositionId,
					Title = "Software Engineer",
					StartDate = new DateTime(2021, 8, 1),
					EndDate = new DateTime(2026, 8, 1),
					CompanyId = ssCompanyId
				}
			);

			// S&S Qualifications
			modelBuilder.Entity<Qualification>().HasData(
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000044"), PositionId = ssPositionId, Description = "VB.Net" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000043"), PositionId = ssPositionId, Description = "ADO.Net" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000042"), PositionId = ssPositionId, Description = "MSSQL" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000041"), PositionId = ssPositionId, Description = "DevExpress" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000040"), PositionId = ssPositionId, Description = "JavaScript" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000039"), PositionId = ssPositionId, Description = "ASP.Net WebForms" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000038"), PositionId = ssPositionId, Description = "CSS/LESS" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000037"), PositionId = ssPositionId, Description = "C#" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000036"), PositionId = ssPositionId, Description = "ASP.Net Core" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000035"), PositionId = ssPositionId, Description = "Blazor" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000034"), PositionId = ssPositionId, Description = "Azure DevOps" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000033"), PositionId = ssPositionId, Description = "Jira" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000032"), PositionId = ssPositionId, Description = "AWS" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000031"), PositionId = ssPositionId, Description = "SEO Development" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000030"), PositionId = ssPositionId, Description = "Scrum Methodology" }
			);

			// S&S Experience
			modelBuilder.Entity<Experience>().HasData(
				new Experience { Id = Guid.Parse("a1000000-0000-0000-0000-000000000028"), PositionId = ssPositionId, Description = "Maintaining and building features for E-commerce and ERP VB.Net WebForm applications" },
				new Experience { Id = Guid.Parse("a1000000-0000-0000-0000-000000000029"), PositionId = ssPositionId, Description = "Documenting features and processes for both software team and external departments" },
				new Experience { Id = Guid.Parse("a1000000-0000-0000-0000-000000000027"), PositionId = ssPositionId, Description = "Modernizing tech stack to use C# ASP.Net Core and Blazor" }
			);

			// AT&T Contact
			var attContactId = Guid.Parse("99999999-9999-9999-9999-999999999999");
			modelBuilder.Entity<Contact>().HasData(
				new Contact
				{
					Id = attContactId,
					AddressLine1 = "",
					AddressLine2 = "",
					State = "IL",
					City = "Schaumburg",
					ZIP = "60159",
					PhoneNumber = "",
					Email = ""
				}
			);

			// AT&T Company
			var attCompanyId = Guid.Parse("10940698-0191-0009-0009-100917666666");
			modelBuilder.Entity<Company>().HasData(
				new Company
				{
					Id = attCompanyId,
					CompanyName = "AT&T (through iAOS Solutions)",
					CompanyContactId = attContactId
				}
			);

			// AT&T Position
			var attPositionId = Guid.Parse("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20");
			modelBuilder.Entity<Position>().HasData(
				new Position
				{
					Id = attPositionId,
					Title = "Software Developer",
					StartDate = new DateTime(2019, 2, 1),
					EndDate = new DateTime(2020, 12, 1),
					CompanyId = attCompanyId
				}
			);

			//AT&T Qualifications
			modelBuilder.Entity<Qualification>().HasData(
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000026"), PositionId = attPositionId, Description = "C#" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000025"), PositionId = attPositionId, Description = "ASP.Net Razor" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000024"), PositionId = attPositionId, Description = "JavaScript" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000023"), PositionId = attPositionId, Description = "Oracle 11g" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000022"), PositionId = attPositionId, Description = "PL/SQL" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000021"), PositionId = attPositionId, Description = "Azure DevOps" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000020"), PositionId = attPositionId, Description = "Scrum/Agile" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000019"), PositionId = attPositionId, Description = "MSSQL" }
			);

			// AT&T Experience
			modelBuilder.Entity<Experience>().HasData(
				new Experience { Id = Guid.Parse("a1000000-0000-0000-0000-000000000017"), PositionId = attPositionId, Description = "Built Windows Service from the ground up for distributing data processing application, including developer documentation" },
				new Experience { Id = Guid.Parse("a1000000-0000-0000-0000-000000000018"), PositionId = attPositionId, Description = "Maintained and added new features for existing ASP.Net MVC application" }
			);


			// Tritech Contact
			var trtContactId = Guid.Parse("12727278-9221-7772-1727-222277772666");
			modelBuilder.Entity<Contact>().HasData(
				new Contact
				{
					Id = trtContactId,
					AddressLine1 = "",
					AddressLine2 = "",
					State = "IA",
					City = "Decorah",
					ZIP = "52101",
					PhoneNumber = "",
					Email = ""
				}
			);

			// Tritech Company
			var trtCompanyId = Guid.Parse("12bbb67b-9b01-1bb2-1bb4-1516b7b8b92b");
			modelBuilder.Entity<Company>().HasData(
				new Company
				{
					Id = trtCompanyId,
					CompanyName = "TriTech Software Solutions",
					CompanyContactId = trtContactId
				}
			);

			// Tritech Position
			var trtPositionId = Guid.Parse("1abcdef8-9101-1112-1314-151ab7cd1e2f");
			modelBuilder.Entity<Position>().HasData(
				new Position
				{
					Id = trtPositionId,
					Title = "Associate Software Engineer",
					StartDate = new DateTime(2016, 7, 1),
					EndDate = new DateTime(2018, 7, 1),
					CompanyId = trtCompanyId
				}
			);

			// Tritech Qualification
			modelBuilder.Entity<Qualification>().HasData(
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000016"), PositionId = trtPositionId, Description = "C#" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000015"), PositionId = trtPositionId, Description = "MVC Framework" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000014"), PositionId = trtPositionId, Description = "TypeScript" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000013"), PositionId = trtPositionId, Description = "AngularJS" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000012"), PositionId = trtPositionId, Description = "KendoUI Library" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000011"), PositionId = trtPositionId, Description = "Domain-Driven Design" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000009"), PositionId = trtPositionId, Description = "MSSQL" }
			);

			// Tritech Experience
			modelBuilder.Entity<Experience>().HasData(
				new Experience { Id = Guid.Parse("a1000000-0000-0000-0000-000000000010"), PositionId = trtPositionId, Description = "Updated and maintained two ASP.Net MVC Web application using C#, Typescript, AngularJS, the KendoUI Library, and Entity Framework, based in an Agile Environment" }
			);

			// LHI Contact
			var lhiContactId = Guid.Parse("12341118-1241-1112-1314-151425522123");
			modelBuilder.Entity<Contact>().HasData(
				new Contact
				{
					Id = lhiContactId,
					AddressLine1 = "",
					AddressLine2 = "",
					State = "WI",
					City = "La Crosse",
					ZIP = "54601",
					PhoneNumber = "",
					Email = ""
				}
			);

			// LHI Company
			var lhiCompanyId = Guid.Parse("12395698-9901-1912-1914-199917181920");
			modelBuilder.Entity<Company>().HasData(
				new Company
				{
					Id = lhiCompanyId,
					CompanyName = "Logistics Health, Inc.",
					CompanyContactId = lhiContactId
				}
			);

			// LHI Position
			var lhiPositionId = Guid.Parse("12345678-9101-1112-1314-151617181920");
			modelBuilder.Entity<Position>().HasData(
				new Position
				{
					Id = lhiPositionId,
					Title = "Software Developer Intern",
					StartDate = new DateTime(2014, 2, 1),
					EndDate = new DateTime(2015, 6, 1),
					CompanyId = lhiCompanyId
				}
			);

			// LHI Qualification
			modelBuilder.Entity<Qualification>().HasData(
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000001"), PositionId = lhiPositionId, Description = "VB.Net" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000002"), PositionId = lhiPositionId, Description = "ADO.Net" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000003"), PositionId = lhiPositionId, Description = "DevExpress" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000004"), PositionId = lhiPositionId, Description = "MSSQL" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000005"), PositionId = lhiPositionId, Description = "WebForms" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000006"), PositionId = lhiPositionId, Description = "WinForms" },
				new Qualification { Id = Guid.Parse("a1000000-0000-0000-0000-000000000007"), PositionId = lhiPositionId, Description = "TFS" }
			);

			// LHI Experience
			modelBuilder.Entity<Experience>().HasData(
				new Experience { Id = Guid.Parse("a1000000-0000-0000-0000-000000000008"), PositionId = lhiPositionId, Description = "Updated and maintained WinForm and ASP.Net WebForm applications using VB.Net and SQL in an Agile/Scrum Environment" }	
			);
		}

		public DbSet<Company> Company => Set<Company>();
		public DbSet<Contact> Contact => Set<Contact>();
		public DbSet<Position> Position => Set<Position>();
		public DbSet<Qualification> Qualification => Set<Qualification>();
		public DbSet<Education> Education => Set<Education>();
		public DbSet<Experience> Experience => Set<Experience>();
	}
}
