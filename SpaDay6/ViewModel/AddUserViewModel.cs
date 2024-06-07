using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModel;

public class AddUserViewModel
{
//*Properties

    //Username Property with Validation Attributes
    [Required(ErrorMessage = "User name is required.")]
    [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be 5-15 characters long.")]
    public string? Username { get; set; }

    //Password Property with Validation Attributes
    [Required(ErrorMessage = "Password is required.")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be 6-20 characters long.")]
    public string? Password { get; set; }

    //Verify Password Property with Validation Attributes
    [Required(ErrorMessage = "Password verification is required.")]
    [Compare("Password", ErrorMessage = "Password must match verify password!")]
    public string? VerifyPassword { get; set; }

    //Email Property with Validation Attributes
    [EmailAddress]
    public string? Email { get; set; }



}