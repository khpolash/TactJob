using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
	public class Reference :BaseEntity
	{
		[Required]
		[Display(Name ="Name")]
        public string ReferenceName { get; set; }

		[Required]
		[Display(Name = "Designation")]
		public string Designation { get; set; }

		[Required]
		[Display(Name = "Organization")]
		public string Organization { get; set; }

		[Required]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[Display(Name = "Mobile")]
		public string Mobile { get; set; }


		[Required]
		[Display(Name = "Phone (Off) ")]
		public string OffPhone { get; set; }


		[Required]
		[Display(Name = "Phone (Res) ")]
		public string ResPhone { get; set; }



		public long RelativeId { get;set; }
		public Relative Relative { get; set; }


		public long  JobseekerId { get; set; }
		public Jobseeker Jobseeker { get; set; }	

	}
}
