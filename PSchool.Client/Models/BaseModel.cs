namespace PSchool.Client.Models;
using System.ComponentModel.DataAnnotations;
public class BaseModel
{
    
    [Required(ErrorMessage = "First Name is required.")]
    [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
    public string FirstName { get; set; } = null!;
    
    [Required(ErrorMessage = "Second Name is required.")]
    [StringLength(50, ErrorMessage = "Second Name cannot exceed 50 characters.")]
    public string SecondName { get; set; } = null!;
    
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; } = null!;
    
    [Required(ErrorMessage = "Phone Number is required.")]
    [RegularExpression(@"^\+\d{10,15}$", ErrorMessage = "Phone number must start with a '+' and contain 10 to 15 digits.")]
    public string PhoneNumber { get; set; } = null!;
}