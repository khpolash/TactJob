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
    public class Relative:BaseEntity
    {
        [Required]
        [Display(Name = "Relative Name")]
        public string RelativeName { get; set; }
		public IList<Reference> References { get; set; }
	}
}
