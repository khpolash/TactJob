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
    public class Country:BaseEntity
    {
        [Required]
        [Display(Name = "Country Name")]

        public string CountryName { get; set; }

        public IList<TrainingSummary>  TrainingSummaries { get; set; }
        public IList<PreferredAreas> PreferredAreas { get; set; }

        public IList<District> Districts { get; set; }
        public IList<Company>  Companies { get; set; }
        public IList<PermanentAddress>  PermanentAddresses { get; set; }

        public IList<PresentAddress>  PresentAddresses { get; set; }

    }
}
