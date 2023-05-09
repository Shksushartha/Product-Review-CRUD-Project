using System;
using System.ComponentModel.DataAnnotations;

namespace authentication.ViewModels
{
	public class Register
	{
		public Register()
		{
		}
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = "Password and confirm password mismatch")]
		public string ConfirmPassword { get; set; }
	}
}

