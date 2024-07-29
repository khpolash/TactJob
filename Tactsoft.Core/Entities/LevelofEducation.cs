using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class LevelofEducation:BaseEntity
    {
        [Required]
        public string LevelofEducationName { get; set; }
        public IList<AcademicSummary>  AcademicSummaries { get; set; }
    }
}
