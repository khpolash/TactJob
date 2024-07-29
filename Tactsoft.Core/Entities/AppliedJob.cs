using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class AppliedJob :BaseEntity
    {
        public long JobseekerId { get; set; }
        public Jobseeker Jobseeker { get; set; }

        public long PostingJobsId { get; set; }
        public PostingJobs PostingJobs { get; set; }
    }
}
