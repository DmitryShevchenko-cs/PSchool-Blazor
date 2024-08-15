namespace PSchool.Client.Models;

public class StudentViewModel : BaseModel
{
    public int Id { get; set; }
    public string Group { get; set; } = null!;
    public ICollection<BaseModel> Parents { get; set; } = null!;
}