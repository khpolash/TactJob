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
    public class Thana:BaseEntity
    {
        [Display(Name = "Thana Name")]
        [Required]
        public string ThanaName { get; set; }
        public IList<PermanentAddress> PermanentAddresses { get; set; }
        public long DistrictId { get; set; }

        public IList<PresentAddress> PresentAddresses { get; set; }
        public District District { get; set; }
        public IList<Company> Companies { get; set; }
    }
}
