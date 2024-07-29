using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class TrainingSummary:BaseEntity
    {
        [Required]
        public string TrainingTitleName { get; set; }
        [Required]
        public long CountryId { get; set; }
        public Country country { get; set; }
        [Required]
        public string TopicsCovered { get; set; }
        [Required]
        public long YearId { get; set; }

        public YearOfPassing YearOfPassing { get; set; }
        [Required]
        public string InstituteName { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string Location { get; set; }
        public long JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }
    }
}
