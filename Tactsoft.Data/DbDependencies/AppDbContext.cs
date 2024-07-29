using Tactsoft.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Reflection;
using Tactsoft.Data.DbDependencies;

namespace Tactsoft.Service.DbDependencies
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
			


		}

		#region Properties

		public DbSet<Country> Countries { get;set; }
        public DbSet<District> Districts { get;set; }
        public DbSet<Thana> Thanas { get; set; }
       
        public DbSet<Relative>  Relatives { get; set; }
        public DbSet<Reading> Readings { get; set; }
        public DbSet<Writing> Writings { get; set; }
        public DbSet<Speaking> Speakings { get; set; }
        
        public DbSet<IndustryType>  IndustryTypes { get; set; }
        public DbSet<CompanySize>  CompanySizes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobCategory>  JobCategories { get; set; }
        public DbSet<ResumeReceivingOption>  ResumeReceivings { get; set; }
        public DbSet<ServiceType>  ServiceTypes { get; set; }
        public DbSet<Jobseeker> Jobseekers { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
       
        public DbSet<PostingJobs>  PostingJobs { get; set; }
        public DbSet<OrganizationType> OrganizationTypes { get; set; }
        
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Result>  Results { get; set; }
        public DbSet<AcademicSummary>  AcademicSummaries { get; set; }

        public DbSet<LevelofEducation> LevelofEducations { get; set; }
        public DbSet<TrainingSummary>  TrainingSummaries { get; set; }
        public DbSet<ProfessionalCertificationSummary>  ProfessionalCertifications { get; set; }
        public DbSet<OtherRelevantInformation>  OtherRelevantInformations { get; set; }
        public DbSet<SpecialSkills>  SpecialSkills { get; set; }
       
        public DbSet<CareerAndApplicationInfo> CareerAndApplications { get; set; }
        public DbSet<PermanentAddress>  PermanentAddresses { get; set; }
        public DbSet<DisabilityInformation>  DisabilityInformation { get; set; }
        public DbSet<EmployHistory>  EmployHistories { get; set; }
        public DbSet<Expertise>  Expertises { get; set; }
        public DbSet<JobseekerSkill> JobseekerSkills { get; set;}
        public DbSet<Photography> Photographies { get; set; }
        public DbSet<LanguageProficiency> LanguageProficiencies { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<AppliedJob>  AppliedJobs { get; set; }


        public DbSet<JobApplication> JobApplications { get; set; }

        #endregion



        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.LogTo(message => WriteSqlQueryLog(message));
            optionsBuilder.UseLoggerFactory(_myLoggerFactory);
        }

        public const string DefaultSchemaName = "dbo";
        public string Schema { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema(Schema);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.RelationConvetion();
            builder.DecimalConvention();
            builder.DateTimeConvention();

            builder.Seed();
        }

        public static readonly Microsoft.Extensions.Logging.LoggerFactory _myLoggerFactory = new LoggerFactory(new[] {
            new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()
                //new ConsoleLoggerProvider((_, __) => true, true)
        });

        private void WriteSqlQueryLog(string query, StoreType storeType = StoreType.Output)
        {
            if (storeType == StoreType.Output)
                Debug.WriteLine(query);
            else if (storeType == StoreType.Db)
            {
                // store in db
            }
            else if (storeType == StoreType.File)
            {
                // store & append in file
                //new StreamWriter("mylog.txt", append: true);
            }

            //using (WebAppContext context = new WebAppContext())
            //{
            //    context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //}

            //IQueryable queryable = from x in Blogs
            //                       where x.Id == 1
            //                       select x;

            //var sqlEf5 = ((System.Data.Objects.ObjectQuery)queryable).ToTraceString();
            //var sqlEf6 = ((System.Data.Entity.Core.Objects.ObjectQuery)queryable).ToTraceString();
            //var sql = queryable.ToString();

            // https://docs.microsoft.com/en-us/ef/ef6/fundamentals/logging-and-interception?redirectedfrom=MSDN
            // https://stackoverflow.com/questions/1412863/how-do-i-view-the-sql-generated-by-the-entity-framework
        }

        #endregion

        
    }

    public enum StoreType
    {
        Db,
        File,
        Output
    }
}
