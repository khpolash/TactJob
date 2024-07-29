using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class PostingJobs:BaseEntity
    {
       
        [Display(Name = "ServiceType Name")]
        public long ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
     
        [Display(Name = "Job Tittle")]
        public string JobTittle { get; set; }
      
        [Display(Name = "Vacancy No")]
        public double Vacancy { get; set; }

		public long CompanyId { get; set; }
		public Company Company { get; set; }

		public Boolean NA { get; set; }


        [Display(Name = "JobCategory Name")]
        public long JobCategoryeId { get; set; }
        public JobCategory JobCategory { get; set; }


     
        [Display(Name = "Employee Status")]
        public string EmployeeStatus { get;set; }
    
        [Display(Name = "Application Deadline")]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime ApplicationDeadline { get; set; }

      
        [Display(Name = "Resume Option Name")]
        public long ResumeReceivingOptionId { get; set; }
        public ResumeReceivingOption ResumeReceivingOption { get; set; }


       
        public Boolean EmailAddress { get; set; }
        public Boolean HardCoppy { get; set; }
        public Boolean WalkinInterview { get; set; }

        [Display(Name = "Email")]
   
        public string Infoemail { get; set; }

       
        public Boolean MamajobEmail { get; set; }

        [Display(Name = "Special Instruction for job Seekers")]
   
        public string SpecialInstructionforjobSeekers { get; set; }

        [Display(Name = "Company Logo")]
        public string CompanyLogo { get; set; }


   
        [Display(Name = "Job Level")]
        public string JobLevel { get; set; }
       
        [Display(Name = "Key Selling Points")]
        public string KeySellingPoints { get; set; }
       
        [Display(Name = "Job Context")]
        public string JobContext { get; set; }
   
        [Display(Name = "Job Responsibillites")]
        public string JobResponsibillites { get; set; }
      
        [Display(Name = "Work Place")]
        public Boolean WorkatOffice { get; set; }

        public Boolean Workathome { get; set; }

        [Display(Name = "Job Location")]
        public Boolean InsideBangladesh { get; set; }

        public Boolean OutsideBangladesh { get; set; }
      
        [Display(Name = "Job Location")]
        public string JobLocation { get; set; }
      
        [Display(Name = "Salary")]
        public string MinimumSalary { get; set; }
      
        public string MaximumSalary { get; set; }
        [Display(Name = "What Do you want to show for salary in job Detail?")]
        public String JobDetail { get; set; }
        [Display(Name = " Do you want to use this salary in to compare with applicants provided expected salary in applicant list?")]
        public string ApplicantList { get; set; }
        [Display(Name = "Do you want to alert applicant whlie his provided salary is excessive than given salary range at the time of applying ")]
        public string Applying { get; set; }
        //[Display(Name = "Compensation & Other Benfits")]
        public String Nah { get; set; }

        public String TA  { get; set; }
        public String MoblieBil { get; set; }
        public String PensionPlicy { get; set; }
        public String TourAllowance { get; set; }
        public String CreditCard { get; set; }
        public String MedicalAllowance { get; set; }
        public String PerformanceBouns { get; set; }
        public String ProfitShare { get; set; }
        public String Providantfund { get; set; }
        public String Wekekly2Holidays { get; set; }
        public String InsuranceGratulty { get; set; }
        public String OverTimeAllowoanec { get; set; }

   
        [Display(Name = "Lanch Facilitics")]
        public string LanchFacilitics { get; set; }
        [Display(Name = "Salary Review")]
        
        public string SalaryReview { get; set; }
        [Display(Name = "Festivel Bonus")]
       
        public string FestivelBonus { get; set; }
        
        [Display(Name = "Others")]
        public string Others { get; set; }


        
        [Display(Name = "Additional Salary info.")]
        public string AdditionalSalaryinfo { get; set; }
        
        [Display(Name = "Education Requirment")]
        public string EducationRequirment { get; set; }

        
        [Display(Name = "Preferred Education Institution")]
        public string PreferredEducationInstitution { get; set; }
        
        [Display(Name = "Additional Requirment ")]
        public string AdditionalRequirment { get; set; }

        
        [Display(Name = "Training/Trade Course")]
        public string TradeCourse { get; set; }

        
        [Display(Name = "Professional Certification")]
        public string ProfessionalCertification { get; set; }

        
        [Display(Name = "Experience")]
        public string Experience { get; set; }
       
        [Display(Name = "Minimum Year Of Experience")]
        public string MinimumYearofExperience { get; set; }

       
        [Display(Name = "Maximum Year Of Experience")]
        public string MaximumYearofExperience { get; set; }

        [Display(Name = "Fresher are also encouraged to apply")]
        public Boolean FreshersApply { get; set; }
      
        [Display(Name = "Area Of Experience")]
        public string AreaOfExperience { get; set; }
       
        [Display(Name = "Area Of Business")]
        public string AreaOfBusiness { get; set; }
   
        [Display(Name = "Skills")]
        public string Skills { get; set; }
     
        [Display(Name = "Additional Requirements")]
        public string AdditionalRequirements { get; set; }
        [Display(Name = "Gender")]
      
        public string Gender { get; set; }
        [Display(Name = "Age")]
   
        public string Mainage { get; set; }
    
        public string Maxage { get; set; }
        [Display(Name = "Person with disability can apply")]
        public string personwithdisability { get; set; }
        [Display(Name = "Preferred Retired Army Officer")]
        public string PreferredRetiredArmy { get; set; }
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Job Address")]
        public string JobAddress { get; set; }
        [Display(Name = "Industry Type")]
      
        public long? IndustryTypeId { get; set; }
        public IndustryType IndustryType { get; set; }
        [Display(Name = "Company Business")]
        public string CompanyBusiness { get; set; }

        [Display(Name = "Publish On")]
    
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime publishon  { get; set; }
        public IList<AppliedJob> AppliedJobs { get; set; }

        public IList<JobApplication> JobApplications { get; set; }
    }
}
