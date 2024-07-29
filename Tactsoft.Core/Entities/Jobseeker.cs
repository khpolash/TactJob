using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;
using Tactsoft.Core.ViewModel;

namespace Tactsoft.Core.Entities
{
    public class Jobseeker:BaseEntity
    {
        [Required]
        public string JobseekerName { get; set; }
        public string UserName { get; set; }
        public long JobCategoryId { get; set; }
        [Required]
        public JobCategory JobCategory { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public Boolean Agree { get; set; }
        [Required]
        public Boolean Subscribe { get; set; }

        public string   User_type { get; set; }
        
        public IList<AppliedJob>  AppliedJobs { get; set; }

        public IList<JobApplication> JobApplications { get; set; }

        public IList<Reference>  References { get; set; }
		public IList<LanguageProficiency> LanguageProficiencies { get; set; }
		public IList<EmployHistory>  EmployHistories { get; set; }
        public IList<Photography>  Photographies { get; set; }
        public IList<Expertise>  Expertises { get; set; }
        public IList<PersonalDetails> PersonalDetails { get; set; }
        public IList<PermanentAddress> PermanentAddresses { get; set; }
        public IList<PreferredAreas>  PreferredAreas { get; set; }
        public IList<JobseekerSkill>  JobseekerSkills { get; set; }

        public IList<ProfessionalCertificationSummary> ProfessionalCertificationSummary { get; set; }
        public IList<OtherRelevantInformation>  OtherRelevants { get; set; }

        public IList<AcademicSummary> AcademicSummaries
        {
            get; set;
        }
        public IList<PresentAddress> PresentAddresses { get; set; }

        public IList<DisabilityInformation>  DisabilityInformation { get; set; }
        public IList<TrainingSummary> TrainingSummaries { get; set; }

        public IList<CareerAndApplicationInfo> careerAndApplicationInfos { get; set; }
    }
}
