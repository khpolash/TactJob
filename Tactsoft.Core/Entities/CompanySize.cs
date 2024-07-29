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
    public class CompanySize:BaseEntity
    {
        [Required]
        [Display(Name = "Company Size")]
        public String CompanyTotalSize { get; set; }
        public IList<Company> Companies { get; set; }
    }
}
