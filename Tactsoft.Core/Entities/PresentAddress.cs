using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class PresentAddress :BaseEntity
    {
        [Required]
        public string PresentInsideBangladesh { get; set; }
        [Required]
        public string PresentOthersAddress { get; set; }

        [Required]
        public long CountryId { get; set; }
        public Country Country { get; set; }



        [Required]
        public long DistrictId { get; set; }

        public District District { get; set; }

        [Required]

        public long ThanaId { get; set; }
        public Thana Thana { get; set; }

        [Required]
        public long BoardId { get; set; }

        public Board Board { get; set; }


        [NotMapped]
        public Boolean SameAsPresentAddress { get; set; }




        public long JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }

    }
}
