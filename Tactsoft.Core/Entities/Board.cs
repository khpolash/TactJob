using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class Board:BaseEntity
    {
        [Required]
        
        [Display(Name = "Board Name")]
        public string BoardName { get; set; }
        public IList<AcademicSummary> AcademicSummaries { get; set; }
        public IList<PermanentAddress> PermanentAddresses { get; set; }
        public IList<PresentAddress> PresentAddresses { get; set; }
    }
}
