namespace PSchool.Client.Models;

public class ParentViewModel : BaseModel
{
    public int Id { get; set; }
    public ICollection<StudentViewModel> Children { get; set; } = null!;
}