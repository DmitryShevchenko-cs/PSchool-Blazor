namespace PSchool.Client.Models;

public class StudentPropModel : BaseModel
{
    public int Id { get; set; }
    public string Group { get; set; } = null!;
}