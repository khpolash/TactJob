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
    public class Expertise :BaseEntity
    {
        [Required]
        [Display(Name = "Expertise Name")]
        public string ExpertiseName { get; set; }
		public IList<EmployHistory> EmployHistories { get; set; }
	}
}
