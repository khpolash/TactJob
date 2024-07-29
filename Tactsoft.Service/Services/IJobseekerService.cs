using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;
using Tactsoft.Core.ViewModel;
using Tactsoft.Service.Services.Base;

namespace Tactsoft.Service.Services
{
    public interface IJobseekerService :IBaseService<Jobseeker>
    {

		long GetIdByUeseName(string userName);

		//IEnumerable<PersonalDetails> Jobseekerinfo(long jobsekkeryId);

		IEnumerable<PersonalDetails> Jobseekerinfo(long SeekerId);
		Jobseeker GetJobseekerByUserName(string UserName);
       
    }
}
