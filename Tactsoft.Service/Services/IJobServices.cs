using System.Collections;
using Tactsoft.Core.Entities;
using Tactsoft.Core.ViewModel;

namespace Tactsoft.Service.Services
{
    public interface IJobServices
    {
        IEnumerable<JobViewModel> GetJobByCategory();
        IEnumerable<HotJobsView> HotJobsView();

        IEnumerable<PostingJobs> Searchvaleu(string a, string b, string c);

        IEnumerable<TotalJobTiltleView> TotalJobTiltleView();

        double NumberOfVacancies();

		IEnumerable<PostingJobs> Companyjobs(long companyId);

  



        double NumberOfJobs();
        double NumberOfNewJobs();
        double NumberOfCompanies();
        double CountOfJobs(long companyId);
        IEnumerable<VmApplyingJobseeker> VmApplyingJobseekers(long CompanyId);

        //double NumberOfItJob();


    }
}
