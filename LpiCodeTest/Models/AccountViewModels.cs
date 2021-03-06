﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LpiCodeTest.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
		[EmailAddress]
		[Display(Name = "Email Address")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

		public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
		[EmailAddress]
		[Display(Name = "Email Address")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

	public class ListViewModel
	{
		[Display(Name = "User Name")]
		public string UserName { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[EmailAddress]
		[Display(Name = "Email Address")]
		public string Email { get; set; }

		[Display(Name = "Driver's License Number")]
		public string DriversLicenseNumber { get; set; }

		[Phone]
		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }

		[Display(Name = "Car Make")]
		public string CarMake { get; set; }

		[Display(Name = "Car Model")]
		public string CarModel { get; set; }

		[Display(Name = "Is Administrator")]
		public bool IsAdministrator { get; set; }
	}

	public class RegisterViewModel
    {
		[Required]
		[Display(Name = "User Name")]
		public string UserName { get; set; }

		[Required]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Required]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		[Display(Name = "Email Address")]
		public string Email { get; set; }

		[Required]
		[Display(Name = "Driver's License Number")]
		public string DriversLicenseNumber { get; set; }

		[Required]
		[Phone]
		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }

		[Required]
		[Display(Name = "Car Make")]
		public string CarMake { get; set; }

		[Required]
		[Display(Name = "Car Model")]
		public string CarModel { get; set; }

		[Display(Name = "Is Administrator")]
		public bool IsAdministrator { get; set; }

		[Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}
