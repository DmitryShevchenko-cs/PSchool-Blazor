namespace PSchool.Client.Models;
using System.ComponentModel.DataAnnotations;

public class StudentUpdateModel : BaseModel
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Group is required.")]
    public string Group { get; set; } = null!;
}