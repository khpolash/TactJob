using System.Collections;
using System.ComponentModel.Design;
using Tactsoft.Core.Entities;
using Tactsoft.Core.ViewModel;
using Tactsoft.Service.DbDependencies;

namespace Tactsoft.Service.Services
{
    public class JobServices: IJobServices
    {
        private readonly AppDbContext _dbContext;
        public JobServices(AppDbContext context) 
        {
            this._dbContext = context;
        }

        public IEnumerable<JobViewModel> GetJobByCategory()
        {
            var jobViewModel = (from a in _dbContext.PostingJobs
                                join b in _dbContext.JobCategories on a.JobCategoryeId equals b.Id
                                select new {b.Id, b.JobCategoryeName,b.JobCategoryeLogo}
                         ).GroupBy(x => new { x.Id, x.JobCategoryeName,x.JobCategoryeLogo})
                   .Select(g => new JobViewModel { Id = g.Key.Id, JobCategoryName = g.Key.JobCategoryeName,JobcategoryLogo=g.Key.JobCategoryeLogo ,TotalJob = g.Count() }).ToList();

            return jobViewModel;
        }

        public IEnumerable<HotJobsView> HotJobsView()
        {
            var data = (from a in _dbContext.PostingJobs
                        select new  { a.CompanyName, a.CompanyLogo, a.JobTittle, a.Id })
                   .Select (g => new HotJobsView { Id = g.Id, CompanyName = g.CompanyName,ComapnyLogo=g.CompanyLogo,Jobtitle=g.JobTittle }).ToList();
            return data;
        }

        public double NumberOfCompanies()
        {
            return _dbContext.Companies.ToList().Count();
        }


		//public double NumberOfItJob()
		//{


		//	var data = _dbContext.PostingJobs.Where().Count();

		//	return data;
		//}





		public double NumberOfJobs()
        {
            return _dbContext.PostingJobs.ToList().Count();
        }

        public double NumberOfNewJobs()
        {
            return _dbContext.PostingJobs.Where(x => x.publishon == DateTime.Now).ToList().Count();
        }

        public double NumberOfVacancies()
        {
            return _dbContext.PostingJobs.Sum(x => x.Vacancy);
        }


		


		public IEnumerable<PostingJobs> Searchvaleu(string a, string b, string c)
        {
            var data = _dbContext.PostingJobs.Where(x => x.JobTittle.Contains(a) || x.JobLocation.Contains(b) || x.IndustryType.IndustryTypeName.Contains(c)).ToList();


            return data;
        }

        public IEnumerable<TotalJobTiltleView> TotalJobTiltleView()
        {
            var jobViewModel = (from a in _dbContext.PostingJobs select new { a.Id, a.JobTittle }).GroupBy(x => new { x.Id, x.JobTittle })
          .Select(g => new TotalJobTiltleView { Id = g.Key.Id, JobTitle = g.Key.JobTittle, TotalJob =g.Count() }).ToList();

            return jobViewModel;
        }

        //public IEnumerable<PostingJobs> Companyjobs(long companyId)
        //{


        //    var data = _dbContext.PostingJobs.Where(x => x.CompanyId == companyId);
        //    return data;
        //}

        public IEnumerable<PostingJobs> Companyjobs(long companyId)
        {


            var data = _dbContext.PostingJobs.Where(x => x.CompanyId == companyId);
            return data;
        }




        






        public double CountOfJobs(long companyId)
		{
			var data = _dbContext.PostingJobs.Where(x => x.CompanyId == companyId).Count();
			return data;
		}

        public IEnumerable<VmApplyingJobseeker> VmApplyingJobseekers(long CompanyId)
        {
            var datas = (from jobApplication in _dbContext.JobApplications
						join postingJob in _dbContext.PostingJobs on jobApplication.PostingJobsId equals postingJob.Id
						join jobseeker in _dbContext.Jobseekers on jobApplication.JobseekerId equals jobseeker.Id
						join company in _dbContext.Companies on postingJob.CompanyId equals CompanyId
						select new VmApplyingJobseeker
                        {                   
                            Email = jobseeker.EmailAddress,
                            JobseekerName = jobseeker.JobseekerName,
                            JobTittle = postingJob.JobTittle,
							//Count = jobseeker.JobseekerName

                        }).Distinct();

            return datas.ToList();

        }
    }
}
