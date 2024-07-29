using System.ComponentModel.DataAnnotations;

namespace Tactsoft.Core.ViewModel
{
    public class LoginViewModel
	{
        [Display(Name ="Enter Uesrname")]
        [Required]
        public string UserName { get; set; }
        [Display(Name = "Enter Password")]
        [Required]
        public string Password { get; set; }
    }
}
