using Tactsoft.Core.Entities;

namespace Tactsoft.Core.ViewModel
{
    public class FrontendViewModel
    {
        public IEnumerable<JobViewModel> JobViewModels { get; set; }
        public IEnumerable<HotJobsView> HotJobsView { get; set; }
        public IEnumerable<TotalJobTiltleView>  TotaslJobTiltles { get; set; }



        public double NumberOfVacancies { get; set; }
        public double NumberOfJobs { get; set; }
        public double NumberOfNewJobs { get; set; }
        public double NumberOfCompanies { get; set; }

		public double NumberOfItJob { get; set; }
		public IEnumerable<PostingJobs> Companyjobs { get; set; }

        public ICollection<JobApplication> JobApplications { get; set; }

        public IEnumerable<PersonalDetails> JobSeekerInfo { get; set; }
		public double CountOfJobs { get; set; }
        public IEnumerable<VmApplyingJobseeker>  VmApplyingJobseekers { get; set; }






    }
}
