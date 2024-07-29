using Tactsoft.Service.Services.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tactsoft.Service.Services;

namespace Tactsoft.Service.Dependency
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
           
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IDistrictService, DistrictService>();
            services.AddScoped<IThanaService,ThanaService>();
           
         
            services.AddScoped<IRelativeService, RelativeService>();
            services.AddScoped<IReadingService, ReadingService>();
            services.AddScoped<IWritingService, WritingService>();
            services.AddScoped<ISpeakingService, SpeakingService>();
            services.AddScoped<IIndustryTypeService, IndustryTypeService>();
            services.AddScoped<ICompanySizeService, CompanySizeService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IJobCategoryService, JobCategoryService>();
            services.AddScoped<IResumeReceivingOptionService, ResumeReceivingOptionService>();
            services.AddScoped<IServiceTypeService, ServiceTypeService>();
            services.AddScoped<IPostingJobsService, PostingJobsService>();
            services.AddScoped<IJobServices, JobServices>();
            services.AddScoped<IOrganizationTypeService, OrganizationTypeService>();
           
            services.AddScoped<ILevelofEducationService, LevelofEducationService>();
            services.AddScoped<IBloodGroupService, BloodGroupService>();
            services.AddScoped<IBoardService, BoardService>();
            services.AddScoped<IDegreeTitleService, DegreeTitleService>();
            services.AddScoped<IYearOfPassingService, YearOfPassingService>();
            services.AddScoped<IResultService, ResultService>();
            services.AddScoped<IJobseekerService, JobseekerService>();
            services.AddScoped<IPersonalDetailsService, PersonalDetailsService>();
            services.AddScoped<IAcademicSummaryService, AcademicSummaryService>();
            services.AddScoped<ITrainingSummaryService, TrainingSummaryService>();
            services.AddScoped<IProfessionalCertificationService, ProfessionalCertificationService>();
            services.AddScoped<IOtherRelevantInformationService, OtherRelevantInformationService>();
            services.AddScoped<ISpecialSkillsService, SpecialSkillsService>();
            services.AddScoped<IPreferredAreasService, PreferredAreasService>();
            services.AddScoped<ICareerAndApplicationInfoService, CareerAndApplicationInfoService>();
            services.AddScoped<IPresentAddressesService, PresentAddressesService>();
            services.AddScoped<IPermanentAddressService, PermanentAddressService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPhotographyService, PhotographyService>();
            services.AddScoped<IExpertiseService, ExpertiseService>();
            services.AddScoped<IEmployHistoryService, EmployHistoryService>();
            services.AddScoped<IJobseekerSkillService, JobseekerSkillService>();
			services.AddScoped<ILanguageProficiencyService, LanguageProficiencyService>();
            services.AddScoped<IReferenceService, ReferenceService>();

            services.AddScoped<IJobApplicationService, JobApplicationService>();
        }
    }
}
