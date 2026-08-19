using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Portfolio.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Contact_CompanyContactId",
                        column: x => x.CompanyContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DegreeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_Contact_SchoolContactId",
                        column: x => x.SchoolContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Position_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experience_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qualification_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Email", "PhoneNumber", "State", "ZIP" },
                values: new object[,]
                {
                    { new Guid("01010101-0101-0101-0101-010101010101"), "", "", "La Crosse", "", "", "WI", "54601" },
                    { new Guid("12341118-1241-1112-1314-151425522123"), "", "", "La Crosse", "", "", "WI", "54601" },
                    { new Guid("12727278-9221-7772-1727-222277772666"), "", "", "Decorah", "", "", "IA", "52101" },
                    { new Guid("33333333-3333-3333-3333-333313333933"), "", "", "Bolingbrook", "", "", "IL", "60440" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "", "", "Schaumburg", "", "", "IL", "60159" }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CompanyContactId", "CompanyName" },
                values: new object[,]
                {
                    { new Guid("10940698-0191-0009-0009-100917666666"), new Guid("99999999-9999-9999-9999-999999999999"), "AT&T (through iAOS Solutions)" },
                    { new Guid("12395698-9901-1912-1914-199917181920"), new Guid("12341118-1241-1112-1314-151425522123"), "Logistics Health, Inc." },
                    { new Guid("12bbb67b-9b01-1bb2-1bb4-1516b7b8b92b"), new Guid("12727278-9221-7772-1727-222277772666"), "TriTech Software Solutions" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new Guid("33333333-3333-3333-3333-333313333933"), "S&S Activewear" }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "DegreeTitle", "EndDate", "SchoolContactId", "SchoolName", "StartDate" },
                values: new object[] { new Guid("10101010-1010-1010-1010-101010101010"), "B.S. Software Application Development", new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01010101-0101-0101-0101-010101010101"), "Globe University", new DateTime(2011, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "CompanyId", "EndDate", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111112"), new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer" },
                    { new Guid("12345678-9101-1112-1314-151617181920"), new Guid("12395698-9901-1912-1914-199917181920"), new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Developer Intern" },
                    { new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f"), new Guid("12bbb67b-9b01-1bb2-1bb4-1516b7b8b92b"), new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Associate Software Engineer" },
                    { new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20"), new Guid("10940698-0191-0009-0009-100917666666"), new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Developer" }
                });

            migrationBuilder.InsertData(
                table: "Experience",
                columns: new[] { "Id", "Description", "PositionId" },
                values: new object[,]
                {
                    { new Guid("a1000000-0000-0000-0000-000000000008"), "Updated and maintained WinForm and ASP.Net WebForm applications using VB.Net and SQL in an Agile/Scrum Environment", new Guid("12345678-9101-1112-1314-151617181920") },
                    { new Guid("a1000000-0000-0000-0000-000000000010"), "Updated and maintained two ASP.Net MVC Web application using C#, Typescript, AngularJS, the KendoUI Library, and Entity Framework, based in an Agile Environment", new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f") },
                    { new Guid("a1000000-0000-0000-0000-000000000017"), "Built Windows Service from the ground up for distributing data processing application, including developer documentation", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000018"), "Maintained and added new features for existing ASP.Net MVC application", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000027"), "Modernizing tech stack to use C# ASP.Net Core and Blazor", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000028"), "Maintaining and building features for E-commerce and ERP VB.Net WebForm applications", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000029"), "Documenting features and processes for both software team and external departments", new Guid("11111111-1111-1111-1111-111111111112") }
                });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "Description", "PositionId" },
                values: new object[,]
                {
                    { new Guid("a1000000-0000-0000-0000-000000000001"), "VB.Net", new Guid("12345678-9101-1112-1314-151617181920") },
                    { new Guid("a1000000-0000-0000-0000-000000000002"), "ADO.Net", new Guid("12345678-9101-1112-1314-151617181920") },
                    { new Guid("a1000000-0000-0000-0000-000000000003"), "DevExpress", new Guid("12345678-9101-1112-1314-151617181920") },
                    { new Guid("a1000000-0000-0000-0000-000000000004"), "MSSQL", new Guid("12345678-9101-1112-1314-151617181920") },
                    { new Guid("a1000000-0000-0000-0000-000000000005"), "WebForms", new Guid("12345678-9101-1112-1314-151617181920") },
                    { new Guid("a1000000-0000-0000-0000-000000000006"), "WinForms", new Guid("12345678-9101-1112-1314-151617181920") },
                    { new Guid("a1000000-0000-0000-0000-000000000007"), "TFS", new Guid("12345678-9101-1112-1314-151617181920") },
                    { new Guid("a1000000-0000-0000-0000-000000000009"), "MSSQL", new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f") },
                    { new Guid("a1000000-0000-0000-0000-000000000011"), "Domain-Driven Design", new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f") },
                    { new Guid("a1000000-0000-0000-0000-000000000012"), "KendoUI Library", new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f") },
                    { new Guid("a1000000-0000-0000-0000-000000000013"), "AngularJS", new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f") },
                    { new Guid("a1000000-0000-0000-0000-000000000014"), "TypeScript", new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f") },
                    { new Guid("a1000000-0000-0000-0000-000000000015"), "MVC Framework", new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f") },
                    { new Guid("a1000000-0000-0000-0000-000000000016"), "C#", new Guid("1abcdef8-9101-1112-1314-151ab7cd1e2f") },
                    { new Guid("a1000000-0000-0000-0000-000000000019"), "MSSQL", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000020"), "Scrum/Agile", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000021"), "Azure DevOps", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000022"), "PL/SQL", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000023"), "Oracle 11g", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000024"), "JavaScript", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000025"), "ASP.Net Razor", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000026"), "C#", new Guid("cc3cc6cc-9ccc-1cc2-1cc4-1cccc71ccc20") },
                    { new Guid("a1000000-0000-0000-0000-000000000030"), "Scrum Methodology", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000031"), "SEO Development", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000032"), "AWS", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000033"), "Jira", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000034"), "Azure DevOps", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000035"), "Blazor", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000036"), "ASP.Net Core", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000037"), "C#", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000038"), "CSS/LESS", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000039"), "ASP.Net WebForms", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000040"), "JavaScript", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000041"), "DevExpress", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000042"), "MSSQL", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000043"), "ADO.Net", new Guid("11111111-1111-1111-1111-111111111112") },
                    { new Guid("a1000000-0000-0000-0000-000000000044"), "VB.Net", new Guid("11111111-1111-1111-1111-111111111112") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_CompanyContactId",
                table: "Company",
                column: "CompanyContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_SchoolContactId",
                table: "Education",
                column: "SchoolContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_PositionId",
                table: "Experience",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_CompanyId",
                table: "Position",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_PositionId",
                table: "Qualification",
                column: "PositionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
