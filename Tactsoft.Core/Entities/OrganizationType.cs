using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class OrganizationType : BaseEntity
    {
        [Required]
        [Display(Name = "Organization Name")]
       
        public string OrganizationName { get; set; }
        public IList<PreferredAreas>  areas { get; set; }
    }
}
