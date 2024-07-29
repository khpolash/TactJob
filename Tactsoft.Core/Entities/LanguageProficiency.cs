using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
	public class LanguageProficiency :BaseEntity
	{
		[Required]
		[Display(Name = "Language")]
        public string LanguageName { get; set; }
		[Required]
		[Display(Name = "Reading")]
		public long ReadingId { get;set; }
		public Reading Reading { get; set; }
		[Required]
		[Display(Name = "Speaking")]
		public long SpeakingId { get; set; }
		public Speaking Speaking { get; set; }
		[Required]
		[Display(Name = "Writing")]
		public long WritingId { get; set; }
		public Writing Writing { get; set; }

		public long  JobseekerId { get; set; }
		public Jobseeker  Jobseeker { get; set; }
    }
}
