namespace PSchool.Client.Models;

public class ParentCreateModel : BaseModel
{
    public ICollection<string> StudentsEmails { get; set; } = null!;
}