namespace PSchool.Client.Models;

public class StudentUpdateModel : BaseModel
{
    public int Id { get; set; }
    public string Group { get; set; } = null!;
}