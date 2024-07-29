using System.ComponentModel.DataAnnotations;
using Tactsoft.Core.Entities;

namespace Tactsoft.Core.ViewModel
{
    public class RegisterViewModel
	{
		[Display(Name ="Full Name")]
		[Required(ErrorMessage ="What's your name?")]
		public string JobseekerName { get; set; }
        
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please Select UserID.")]
        public string UserName { get; set; }

        [Display(Name = "Job Category")]
        [Required(ErrorMessage = "Please select a Category.")]
        public long JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }

        [Required]
		public string Gender { get; set; }

        [Display(Name = "Email Address")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [Required]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Mobile Number cannot be empty.")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Re-enter Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public Boolean Agree { get; set; }
        public Boolean Subscribe { get; set; }
    }
}
