namespace PSchool.Client.Models;

public class ParentViewModel : BaseModel
{
    public int Id { get; set; }
    public ICollection<StudentPropModel> Children { get; set; } = null!;
}