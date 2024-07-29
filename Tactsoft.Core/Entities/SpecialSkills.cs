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
    public class SpecialSkills :BaseEntity
    {
        [Required]
        [Display(Name = "Special Skills Name")]
        public string SpecialSkillsName { get; set; }
        public IList<PreferredAreas> PreferredAreas { get; set; }
    }
}
