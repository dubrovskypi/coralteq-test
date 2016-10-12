using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cor.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class ContactInfoViewModel
    {

        [Required]
        public string Salutation { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FName { get; set; }

        [Display(Name = "Middle name")]
        public string MName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LName { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Confirm Email")]
        [EmailAddress]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Mobile { get; set; }
    }

    public class BusinessAreaViewModel {
        public List<string> BusinessArea { get; set; }
    }

    public class AddressInfoViewModel {
        [Required]
        public string Country { get; set; }

        [Required]
        public string OfficeName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int PostalCode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }
    }

    public class PasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
