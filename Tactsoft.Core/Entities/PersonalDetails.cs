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
    public class PersonalDetails:BaseEntity
    {
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Father's Name")]
        [Required]
        public string FatherName { get; set; }
        [Display(Name = "Mother's Name")]
        [Required]
        public string MotherName { get; set; }
        [Display(Name = "Date of Birth")]
        [Required]
        public DateTime DateofBirth { get; set; }
        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }
        [Display(Name = "Religion")]
        [Required]
        public string Religion { get; set; }
        [Display(Name = "Marital Status")]
        [Required]
        public string MaritalStatus { get; set; }
        [Display(Name = "Nationality")]
        [Required]
        public string Nationality { get; set; }
        [Display(Name = "National Id")]
        [Required]
        public string NationalId { get; set; }
        [Display(Name = "Passport Number")]
        [Required]
        public string PassportNumber { get; set; }
        [Display(Name = "Passport Issue Date")]
        [Required]
        public DateTime PassportIssueDate { get; set; }
        [Display(Name = "Primary Mobile")]
        [Required]
        public string PrimaryMobile { get; set; }
        [Display(Name = "Secondary Mobile")]
        [Required]
        public string SecondaryMobile { get; set; }
        [Display(Name = "Emergency Contact")]
        [Required]
        public string EmergencContact { get; set; }
        [Display(Name = "Primary Email")]
        [Required]
        public string PrimaryEmail { get; set; }
        [Display(Name = "Alternate Email")]
        [Required]

        public string AlternateEmail { get; set; }
        [Display(Name = "Blood Group")]
        [Required]
        public long BloodGroupId { get; set; }
        public BloodGroup BloodGroup { get; set; }

        [Required]
        [Display(Name = "Height (meters)")]
        public string Height { get; set; }
        [Required]
        [Display(Name = "Weight (kg)")]
        public string Weight { get; set; }

        public long ? JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }
    }
}
