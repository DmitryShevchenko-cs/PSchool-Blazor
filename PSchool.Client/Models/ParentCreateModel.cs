using System.ComponentModel.DataAnnotations;

namespace PSchool.Client.Models;

public class ParentCreateModel : BaseModel
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string StudentsEmail { get; set; } = null!;
}