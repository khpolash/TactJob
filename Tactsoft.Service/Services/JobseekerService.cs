using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;
using Tactsoft.Core.ViewModel;
using Tactsoft.Service.DbDependencies;
using Tactsoft.Service.Services.Base;

namespace Tactsoft.Service.Services
{
    public class JobseekerService : BaseService<Jobseeker>, IJobseekerService
    {
        private readonly AppDbContext _dbContext;
        public JobseekerService(AppDbContext context) : base(context)
        {
            _dbContext = context;   
        }

		public long GetIdByUeseName(string userName)
		{
			var Jobseeker = _dbContext.Jobseekers.FirstOrDefault(x => x.UserName == userName);
			return Jobseeker.Id;
		}

        public Jobseeker GetJobseekerByUserName(string UserName)
        {
            return _dbContext.Jobseekers.FirstOrDefault(f=>f.UserName==UserName);
        }

        public IEnumerable<PersonalDetails> Jobseekerinfo(long SeekerId)
		{

			var data = _dbContext.PersonalDetails.Where(x => x.JobseekerId == SeekerId);
			return data;
		}

      
    }
}
