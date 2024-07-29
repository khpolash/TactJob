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
    public class DegreeTitle:BaseEntity
    {
        [Required]
        [Display(Name = "Degree Title Name")]
        public string DegreeTitleName { get; set; }
        public IList<AcademicSummary> AcademicSummaries { get; set; }
    }
}
