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
    public class IndustryType:BaseEntity
    {
        [Display(Name = "Industry Type")]
        [Required]
        public string IndustryTypeName { get; set; }
        public IList<Company> Companies { get; set; }
        public IList<PostingJobs> PostingJobs { get; set; }
    }
}
