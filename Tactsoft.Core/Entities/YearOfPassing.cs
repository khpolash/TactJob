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
    public class YearOfPassing:BaseEntity
    {

        [Required]
        [Display(Name = "Year Of Passing Name")]
        public string YearOfPassingName { get; set; }
        public IList<AcademicSummary> AcademicSummaries
        {
            get; set;
        }
        public IList<TrainingSummary> TrainingSummaries { get; set; }
    }
}
