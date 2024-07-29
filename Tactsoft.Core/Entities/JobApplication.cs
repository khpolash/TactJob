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
    public  class JobApplication : BaseEntity
    {


        public long JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }

        [Display(Name = "Job ApplyDate ")]

        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime ApplyingDate { get; set; }

        public long PostingJobsId { get; set; }

        public PostingJobs PostingJobs { get; set; }

        public string  ExptedSalary { get; set; }



    }
}
