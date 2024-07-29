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
    public class BloodGroup:BaseEntity
    {
        [Required]
        [Display(Name = "Blood Group")]
        public string BloodGroupName { get; set; }
        public IList<PersonalDetails> PersonalDetails { get; set; }
    }
}
