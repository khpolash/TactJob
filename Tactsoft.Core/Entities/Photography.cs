using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class Photography :BaseEntity
    {
        [Display(Name = "Photo")]
        public string PhotoPath { get; set; }
        public long  JobseekerId { get; set; }
        public Jobseeker Jobseeker { get; set; }
    }
}
