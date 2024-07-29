using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Entities;

namespace Tactsoft.Core.ViewModel
{
    public class CompanyRegisterViewModel
    {


        [Display(Name = "Username")]
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Re-enter Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Company Name English(En)")]
        public string CompanyNameEnglishName { get; set; }
        [Required]
        [Display(Name = "Company Name Bangla(Bn)")]
        public string CompanyNameBanglaName { get; set; }

        [Required]
        [Display(Name = "Are you new Entrepreneur?")]
        public string Entrepreneur { get; set; }


        [Required]
        [Display(Name = "Company Size")]
        public long CompanySizeId { get; set; }
        public CompanySize CompanySize { get; set; }
        [Required]
        [Display(Name = "Company Country")]
        public long CountryId { get; set; }
        public Country Country { get; set; }
        [Required]
        [Display(Name = "District Name")]
        public long DistrictId { get; set; }
        public District District { get; set; }
        [Required]
        [Display(Name = "Thana Name")]
        public long ThanaId { get; set; }
        public Thana Thana { get; set; }
        [Required]
        [Display(Name = "Company Address(Bn) ")]
        public string CompanyAddressBangla { get; set; }
        [Required]
        [Display(Name = "Company Address(En) ")]
        public string CompanyAddressEnglish { get; set; }
        [Required]
        [Display(Name = "Industrial Type ")]
        public long IndustialTypeId { get; set; }
        public IndustryType IndustialType { get; set; }
        [Required]
        [Display(Name = "Business Description")]
        public string BusinessDescription { get; set; }
        [Required]
        [Display(Name = " Business Trade Licience No")]

        public string BusinessTradeLicienceNo { get; set; }
        [Required]
        [Display(Name = "RL NO ")]
        public string RLNO { get; set; }
        [Required]
        [Display(Name = "Website URL ")]

        public string WebsiteUrl { get; set; }
        [Required]
        [Display(Name = "Contact Person")]
        public string ContactPersonName { get; set; }
        [Required]
        [Display(Name = "Contact Person Designation ")]
        public string ContactPersonDesignation { get; set; }
        [Required]
        [Display(Name = "Contact Person Email ")]
        public string ContactPersonEmail { get; set; }
        [Required]
        [Display(Name = "Contact Person Mobile ")]
        public string ContactPersonMobile { get; set; }
        [Required]
        [Display(Name = "Company Email ")]
        public string CompanyEmailAdress { get; set; }

    }
}
