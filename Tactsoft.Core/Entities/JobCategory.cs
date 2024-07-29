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
    public class JobCategory:BaseEntity
    {
        [Display(Name = "JobCategory Name")]
        [Required]
        public string JobCategoryeName { get; set; }

		[Display(Name = "JobCategorye  Logo")]
		public string JobCategoryeLogo { get; set; }

		public IList<PostingJobs>  PostingJobs { get; set; }
        public IList<Jobseeker>  Jobseekers { get; set; }
        public IList<PreferredAreas>  PreferredAreas { get; set; }

    }
}
