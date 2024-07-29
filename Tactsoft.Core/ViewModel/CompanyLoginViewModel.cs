using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tactsoft.Core.ViewModel
{
    public class CompanyLoginViewModel
    {
        [Display(Name = "Enter Uesrname")]
        [Required]
        public string UserName { get; set; }
        [Display(Name = "Enter Password")]
        [Required]
        public string Password { get; set; }
    }
}
