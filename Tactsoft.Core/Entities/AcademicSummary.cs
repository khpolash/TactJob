using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class AcademicSummary:BaseEntity
    {
        [Required]
       
        public long LevelofEducationId { get; set; }
        public LevelofEducation LevelofEducation { get; set; }
        [Required]
       
        public long degreeTitleId { get; set; }
        public DegreeTitle degreeTitle { get; set; }
        [Required]
        
        public string Group { get; set; }
        [Required]
        public long boardId { get; set; }
        public Board board { get; set; }
        [Required]
        public string InstituteName { get; set; }
        [NotMapped]

        public Boolean foreigInstitute { get; set; }
        [Required]
        public string ForeignUniversityName { get; set; }

        


        public long ResultId { get; set; }
        public Result Result { get; set; }

        public long YearOfPassingId { get; set; }
        public YearOfPassing YearOfPassing { get; set; }


        public string Duration { get; set; }

        public string Achievement { get; set; }

        public long  JobseekerId { get; set; }

       public Jobseeker Jobseeker { get; set; }

    }
}
