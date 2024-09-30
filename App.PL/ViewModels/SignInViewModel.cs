using System.ComponentModel.DataAnnotations;

namespace App.PL.ViewModels
{
	public class SignInViewModel
	{
		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid Email")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Password is Required")]
		[MinLength(5, ErrorMessage = "Password is short")]
		public string Password { get; set; }
		public bool Rememberme { get; set; }

	}
}
