using System;
using System.ComponentModel.DataAnnotations;

namespace authentication.ViewModels
{
	public class Login
	{
		public Login()
		{
		}
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}

