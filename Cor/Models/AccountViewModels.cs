using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cor.Models
{

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }
    }

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

        //[Required]
        //public AddressInfo AddressInformation { get; set; }

        //public List<string> BusinessArea { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Compare("Password")]
        //public string ConfirmPassword { get; set; }
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

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Почта")]
        public string Email { get; set; }
    }
}
