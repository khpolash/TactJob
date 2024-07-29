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
    public class ServiceType:BaseEntity
    {
        [Display(Name = "Service Type Name")]
        [Required]
        public string ServiceTypeName { get; set; }
        public IList<PostingJobs> PostingJobs { get; set; }
    }
}
