using System.ComponentModel.DataAnnotations;

namespace simpleLoginReg.Models
{
	public class Register
	{
		[Required]
		[MinLength(2)]
		[Display(Name = "First Name")]
		public string FirstName {get;set;}

		[Required]
		[MinLength(2)]
		[Display(Name = "Last Name")]
		public string LastName {get;set;}

		[Required]
		[EmailAddress]
		public string RegisterEmail {get;set;}

		[Required]
		[MinLength(8)]
		[DataType(DataType.Password)]
		public string RegisterPassword {get;set;}

		[Display(Name = "Confirm Password")]
		[DataType(DataType.Password)]
		[Compare(nameof(RegisterPassword), ErrorMessage = "Password mismatch")]
		public string PasswordConfirmation {get;set;}
	}
}