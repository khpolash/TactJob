using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Base;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Tactsoft.Core.Entities
{
    public class District:BaseEntity
    {
        [Required]
        [Display(Name = "District Name")]
       
        public string DistrictName { get; set; }
        [Required]
        [Display(Name = "Country Name")]
      
        public long CountryId { get; set; }
        public Country Countrys { get; set; }

        public IList<Thana> Thanas { get; set; }
       
        public IList<Company> Companies { get; set; }
        public IList<PreferredAreas> PreferredAreas { get; set; }
        public IList<PermanentAddress> PermanentAddresses { get; set; }
        public IList<PresentAddress> PresentAddresses { get; set; }
    }
}
