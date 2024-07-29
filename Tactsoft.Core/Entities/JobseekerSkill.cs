using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class JobseekerSkill :BaseEntity
    {
        [Required]
        public string JobseekerSkillName { get; set; }
        
       
   
        public string Self { get; set; }

        public string job { get; set; }
        public string Educational { get; set; }
        public string professionalTraining { get; set; }
        public string NTVQF { get; set; }

        [Required]
        public string JobseekerSkillDescription { get; set; }
        [Required]
        public string ExtracurricularActivities { get; set; }

        public long  JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }
    }
}
