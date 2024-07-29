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
    public class EmployHistory :BaseEntity
    {
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Company Business Name")]

        public string CompanyBusinessName { get; set; }
        [Required]

        [Display(Name = "Company Location")]

        public string CompanyLocation { get; set; }

        [Required]
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; }
        [Required]
        [Display(Name = "Employe From")]
       
        public DateTime EmployeFrom { get; set; }
        [Required]
        [Display(Name = "Employe To")]
        public DateTime EmployeTo { get; set; }
        [Required]
        [Display(Name = "Current Woring ?")]
        public Boolean CurrentWoring { get; set; }
        [Required]
        [Display(Name = "Responsibility")]
        public string Responsibility { get; set; }
        [Required]
        [Display(Name = "Jobseeker Create")]
        public long  JobseekerId { get; set; }

        public Jobseeker  Jobseeker { get; set; }

        [Display(Name = "Expertise")]
        [Required]
        public long ExpertiseId { get; set; }

        public Expertise Expertises { get; set; }

		[Display(Name = "Expertise")]
		[Required]
		public string ExpertiseTo { get; set; }

		public string Duration { get; set; }
		public IList<Expertise>  Expertise { get; set; }

	}
}
