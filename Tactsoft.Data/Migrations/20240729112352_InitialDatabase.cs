using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tactsoft.Data.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Board",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanySizes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyTotalSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DegreeTitle",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeTitleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndustryTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobCategoryeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobCategoryeLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LevelofEducations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelofEducationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelofEducations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Readings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relatives",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelativeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResumeReceivings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeOption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeReceivings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speakings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialSkills",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialSkillsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Writings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WritingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearOfPassing",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearOfPassingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearOfPassing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jobseekers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agree = table.Column<bool>(type: "bit", nullable: false),
                    Subscribe = table.Column<bool>(type: "bit", nullable: false),
                    User_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobseekers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobseekers_JobCategories_JobCategoryId",
                        column: x => x.JobCategoryId,
                        principalTable: "JobCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Thanas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThanaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thanas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thanas_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AcademicSummaries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelofEducationId = table.Column<long>(type: "bigint", nullable: false),
                    degreeTitleId = table.Column<long>(type: "bigint", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    boardId = table.Column<long>(type: "bigint", nullable: false),
                    InstituteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForeignUniversityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResultId = table.Column<long>(type: "bigint", nullable: false),
                    YearOfPassingId = table.Column<long>(type: "bigint", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Achievement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicSummaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicSummaries_Board_boardId",
                        column: x => x.boardId,
                        principalTable: "Board",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademicSummaries_DegreeTitle_degreeTitleId",
                        column: x => x.degreeTitleId,
                        principalTable: "DegreeTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademicSummaries_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademicSummaries_LevelofEducations_LevelofEducationId",
                        column: x => x.LevelofEducationId,
                        principalTable: "LevelofEducations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademicSummaries_Results_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademicSummaries_YearOfPassing_YearOfPassingId",
                        column: x => x.YearOfPassingId,
                        principalTable: "YearOfPassing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CareerAndApplications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Objective = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentSalary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedSalary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobNature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerAndApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CareerAndApplications_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisabilityInformation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalDisabilityID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisabilityDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisabilityInformation_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobseekerSkills",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerSkillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Self = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Educational = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    professionalTraining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NTVQF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobseekerSkillDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtracurricularActivities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobseekerSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobseekerSkills_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LanguageProficiencies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadingId = table.Column<long>(type: "bigint", nullable: false),
                    SpeakingId = table.Column<long>(type: "bigint", nullable: false),
                    WritingId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageProficiencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageProficiencies_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LanguageProficiencies_Readings_ReadingId",
                        column: x => x.ReadingId,
                        principalTable: "Readings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LanguageProficiencies_Speakings_SpeakingId",
                        column: x => x.SpeakingId,
                        principalTable: "Speakings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LanguageProficiencies_Writings_WritingId",
                        column: x => x.WritingId,
                        principalTable: "Writings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherRelevantInformations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareerSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpeciaQualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherRelevantInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherRelevantInformations_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrimaryMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlternateEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodGroupId = table.Column<long>(type: "bigint", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_BloodGroups_BloodGroupId",
                        column: x => x.BloodGroupId,
                        principalTable: "BloodGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photographies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photographies_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreferredAreas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SpecialSkillsId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    OrganizationId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferredAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreferredAreas_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreferredAreas_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreferredAreas_JobCategories_JobCategoryId",
                        column: x => x.JobCategoryId,
                        principalTable: "JobCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreferredAreas_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreferredAreas_OrganizationTypes_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "OrganizationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreferredAreas_SpecialSkills_SpecialSkillsId",
                        column: x => x.SpecialSkillsId,
                        principalTable: "SpecialSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalCertifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Institute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalCertifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalCertifications_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OffPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelativeId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                    table.ForeignKey(
                        name: "FK_References_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_References_Relatives_RelativeId",
                        column: x => x.RelativeId,
                        principalTable: "Relatives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSummaries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingTitleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    TopicsCovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearId = table.Column<long>(type: "bigint", nullable: false),
                    InstituteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSummaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingSummaries_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingSummaries_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingSummaries_YearOfPassing_YearId",
                        column: x => x.YearId,
                        principalTable: "YearOfPassing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyNameEnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyNameBanglaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entrepreneur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanySizeId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    ThanaId = table.Column<long>(type: "bigint", nullable: false),
                    CompanyAddressBangla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddressEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndustialTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessTradeLicienceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RLNO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEmailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_CompanySizes_CompanySizeId",
                        column: x => x.CompanySizeId,
                        principalTable: "CompanySizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_IndustryTypes_IndustialTypeId",
                        column: x => x.IndustialTypeId,
                        principalTable: "IndustryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Thanas_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thanas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PermanentAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermanentInsideBangladesh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentOthersAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    ThanaId = table.Column<long>(type: "bigint", nullable: false),
                    BoardId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermanentAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermanentAddresses_Board_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Board",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermanentAddresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermanentAddresses_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermanentAddresses_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermanentAddresses_Thanas_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thanas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresentAddress",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresentInsideBangladesh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentOthersAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    ThanaId = table.Column<long>(type: "bigint", nullable: false),
                    BoardId = table.Column<long>(type: "bigint", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresentAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PresentAddress_Board_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Board",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresentAddress_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresentAddress_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresentAddress_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresentAddress_Thanas_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thanas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostingJobs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    JobTittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacancy = table.Column<double>(type: "float", nullable: false),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    NA = table.Column<bool>(type: "bit", nullable: false),
                    JobCategoryeId = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationDeadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResumeReceivingOptionId = table.Column<long>(type: "bigint", nullable: false),
                    EmailAddress = table.Column<bool>(type: "bit", nullable: false),
                    HardCoppy = table.Column<bool>(type: "bit", nullable: false),
                    WalkinInterview = table.Column<bool>(type: "bit", nullable: false),
                    Infoemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MamajobEmail = table.Column<bool>(type: "bit", nullable: false),
                    SpecialInstructionforjobSeekers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeySellingPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobContext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobResponsibillites = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkatOffice = table.Column<bool>(type: "bit", nullable: false),
                    Workathome = table.Column<bool>(type: "bit", nullable: false),
                    InsideBangladesh = table.Column<bool>(type: "bit", nullable: false),
                    OutsideBangladesh = table.Column<bool>(type: "bit", nullable: false),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumSalary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumSalary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Applying = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoblieBil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PensionPlicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourAllowance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalAllowance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerformanceBouns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfitShare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Providantfund = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wekekly2Holidays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceGratulty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OverTimeAllowoanec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanchFacilitics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryReview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FestivelBonus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalSalaryinfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationRequirment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredEducationInstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalRequirment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeCourse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionalCertification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumYearofExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumYearofExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreshersApply = table.Column<bool>(type: "bit", nullable: false),
                    AreaOfExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mainage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maxage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personwithdisability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredRetiredArmy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustryTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CompanyBusiness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    publishon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostingJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostingJobs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostingJobs_IndustryTypes_IndustryTypeId",
                        column: x => x.IndustryTypeId,
                        principalTable: "IndustryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostingJobs_JobCategories_JobCategoryeId",
                        column: x => x.JobCategoryeId,
                        principalTable: "JobCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostingJobs_ResumeReceivings_ResumeReceivingOptionId",
                        column: x => x.ResumeReceivingOptionId,
                        principalTable: "ResumeReceivings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostingJobs_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppliedJobs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    PostingJobsId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliedJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppliedJobs_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppliedJobs_PostingJobs_PostingJobsId",
                        column: x => x.PostingJobsId,
                        principalTable: "PostingJobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    ApplyingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostingJobsId = table.Column<long>(type: "bigint", nullable: false),
                    ExptedSalary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApplications_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobApplications_PostingJobs_PostingJobsId",
                        column: x => x.PostingJobsId,
                        principalTable: "PostingJobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployHistories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyBusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentWoring = table.Column<bool>(type: "bit", nullable: false),
                    Responsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: false),
                    ExpertiseId = table.Column<long>(type: "bigint", nullable: false),
                    ExpertiseTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployHistories_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpertiseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployHistoryId = table.Column<long>(type: "bigint", nullable: true),
                    JobseekerId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expertises_EmployHistories_EmployHistoryId",
                        column: x => x.EmployHistoryId,
                        principalTable: "EmployHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expertises_Jobseekers_JobseekerId",
                        column: x => x.JobseekerId,
                        principalTable: "Jobseekers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CompanySizes",
                columns: new[] { "Id", "CompanyTotalSize", "CreatedBy", "CreatedDateUtc", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, "10 too 100", 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), null, null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "CreatedBy", "CreatedDateUtc", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, "Bangladesh", 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), null, null });

            migrationBuilder.InsertData(
                table: "IndustryTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "IndustryTypeName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "Devlopment", null, null });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "JobCategoryeLogo", "JobCategoryeName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "", "IT", null, null });

            migrationBuilder.InsertData(
                table: "OrganizationTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "OrganizationName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "Government", null, null });

            migrationBuilder.InsertData(
                table: "Readings",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "ReadingName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "Bangla", null, null });

            migrationBuilder.InsertData(
                table: "Relatives",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "RelativeName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "Techer", null, null });

            migrationBuilder.InsertData(
                table: "ResumeReceivings",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "ResumeOption", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "Apply Online", null, null });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "ServiceTypeName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "Stand-out Listing", null, null });

            migrationBuilder.InsertData(
                table: "Speakings",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "SpeakingName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "Bangla", null, null });

            migrationBuilder.InsertData(
                table: "Writings",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "UpdatedBy", "UpdatedDateUtc", "WritingName" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), null, null, "Bangla" });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CountryId", "CreatedBy", "CreatedDateUtc", "DistrictName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "Barisal", null, null });

            migrationBuilder.InsertData(
                table: "Thanas",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "DistrictId", "ThanaName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), 1L, "Porijpuer", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSummaries_boardId",
                table: "AcademicSummaries",
                column: "boardId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSummaries_degreeTitleId",
                table: "AcademicSummaries",
                column: "degreeTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSummaries_JobseekerId",
                table: "AcademicSummaries",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSummaries_LevelofEducationId",
                table: "AcademicSummaries",
                column: "LevelofEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSummaries_ResultId",
                table: "AcademicSummaries",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSummaries_YearOfPassingId",
                table: "AcademicSummaries",
                column: "YearOfPassingId");

            migrationBuilder.CreateIndex(
                name: "IX_AppliedJobs_JobseekerId",
                table: "AppliedJobs",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_AppliedJobs_PostingJobsId",
                table: "AppliedJobs",
                column: "PostingJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_CareerAndApplications_JobseekerId",
                table: "CareerAndApplications",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanySizeId",
                table: "Companies",
                column: "CompanySizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CountryId",
                table: "Companies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DistrictId",
                table: "Companies",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IndustialTypeId",
                table: "Companies",
                column: "IndustialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ThanaId",
                table: "Companies",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_DisabilityInformation_JobseekerId",
                table: "DisabilityInformation",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CountryId",
                table: "Districts",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployHistories_ExpertiseId",
                table: "EmployHistories",
                column: "ExpertiseId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployHistories_JobseekerId",
                table: "EmployHistories",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_EmployHistoryId",
                table: "Expertises",
                column: "EmployHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_JobseekerId",
                table: "Expertises",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobseekerId",
                table: "JobApplications",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_PostingJobsId",
                table: "JobApplications",
                column: "PostingJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobseekers_JobCategoryId",
                table: "Jobseekers",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobseekerSkills_JobseekerId",
                table: "JobseekerSkills",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageProficiencies_JobseekerId",
                table: "LanguageProficiencies",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageProficiencies_ReadingId",
                table: "LanguageProficiencies",
                column: "ReadingId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageProficiencies_SpeakingId",
                table: "LanguageProficiencies",
                column: "SpeakingId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageProficiencies_WritingId",
                table: "LanguageProficiencies",
                column: "WritingId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherRelevantInformations_JobseekerId",
                table: "OtherRelevantInformations",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_PermanentAddresses_BoardId",
                table: "PermanentAddresses",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_PermanentAddresses_CountryId",
                table: "PermanentAddresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PermanentAddresses_DistrictId",
                table: "PermanentAddresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PermanentAddresses_JobseekerId",
                table: "PermanentAddresses",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_PermanentAddresses_ThanaId",
                table: "PermanentAddresses",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_BloodGroupId",
                table: "PersonalDetails",
                column: "BloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_JobseekerId",
                table: "PersonalDetails",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_Photographies_JobseekerId",
                table: "Photographies",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_PostingJobs_CompanyId",
                table: "PostingJobs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PostingJobs_IndustryTypeId",
                table: "PostingJobs",
                column: "IndustryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostingJobs_JobCategoryeId",
                table: "PostingJobs",
                column: "JobCategoryeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostingJobs_ResumeReceivingOptionId",
                table: "PostingJobs",
                column: "ResumeReceivingOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PostingJobs_ServiceTypeId",
                table: "PostingJobs",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredAreas_CountryId",
                table: "PreferredAreas",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredAreas_DistrictId",
                table: "PreferredAreas",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredAreas_JobCategoryId",
                table: "PreferredAreas",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredAreas_JobseekerId",
                table: "PreferredAreas",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredAreas_OrganizationId",
                table: "PreferredAreas",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredAreas_SpecialSkillsId",
                table: "PreferredAreas",
                column: "SpecialSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_PresentAddress_BoardId",
                table: "PresentAddress",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_PresentAddress_CountryId",
                table: "PresentAddress",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PresentAddress_DistrictId",
                table: "PresentAddress",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PresentAddress_JobseekerId",
                table: "PresentAddress",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_PresentAddress_ThanaId",
                table: "PresentAddress",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalCertifications_JobseekerId",
                table: "ProfessionalCertifications",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_References_JobseekerId",
                table: "References",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_References_RelativeId",
                table: "References",
                column: "RelativeId");

            migrationBuilder.CreateIndex(
                name: "IX_Thanas_DistrictId",
                table: "Thanas",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSummaries_CountryId",
                table: "TrainingSummaries",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSummaries_JobseekerId",
                table: "TrainingSummaries",
                column: "JobseekerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSummaries_YearId",
                table: "TrainingSummaries",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployHistories_Expertises_ExpertiseId",
                table: "EmployHistories",
                column: "ExpertiseId",
                principalTable: "Expertises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployHistories_Jobseekers_JobseekerId",
                table: "EmployHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Expertises_Jobseekers_JobseekerId",
                table: "Expertises");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployHistories_Expertises_ExpertiseId",
                table: "EmployHistories");

            migrationBuilder.DropTable(
                name: "AcademicSummaries");

            migrationBuilder.DropTable(
                name: "AppliedJobs");

            migrationBuilder.DropTable(
                name: "CareerAndApplications");

            migrationBuilder.DropTable(
                name: "DisabilityInformation");

            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropTable(
                name: "JobseekerSkills");

            migrationBuilder.DropTable(
                name: "LanguageProficiencies");

            migrationBuilder.DropTable(
                name: "OtherRelevantInformations");

            migrationBuilder.DropTable(
                name: "PermanentAddresses");

            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "Photographies");

            migrationBuilder.DropTable(
                name: "PreferredAreas");

            migrationBuilder.DropTable(
                name: "PresentAddress");

            migrationBuilder.DropTable(
                name: "ProfessionalCertifications");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "TrainingSummaries");

            migrationBuilder.DropTable(
                name: "DegreeTitle");

            migrationBuilder.DropTable(
                name: "LevelofEducations");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "PostingJobs");

            migrationBuilder.DropTable(
                name: "Readings");

            migrationBuilder.DropTable(
                name: "Speakings");

            migrationBuilder.DropTable(
                name: "Writings");

            migrationBuilder.DropTable(
                name: "BloodGroups");

            migrationBuilder.DropTable(
                name: "OrganizationTypes");

            migrationBuilder.DropTable(
                name: "SpecialSkills");

            migrationBuilder.DropTable(
                name: "Board");

            migrationBuilder.DropTable(
                name: "Relatives");

            migrationBuilder.DropTable(
                name: "YearOfPassing");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ResumeReceivings");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "CompanySizes");

            migrationBuilder.DropTable(
                name: "IndustryTypes");

            migrationBuilder.DropTable(
                name: "Thanas");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Jobseekers");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "EmployHistories");
        }
    }
}
