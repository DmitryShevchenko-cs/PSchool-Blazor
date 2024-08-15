using PSchool.Client.Models;

namespace PSchool.Client.Services.Interfaces;

public interface IStudentService
{
    Task<PaginationResponse<StudentViewModel>> GetStudents(PaginationRequest paginationRequest, string parentName = null!,
        CancellationToken cancellationToken = default);
    Task<StudentViewModel> GetStudents(int studentId, CancellationToken cancellationToken = default);
    
    Task<StudentViewModel> PostStudent(StudentCreateModel studentCreateModel,
        CancellationToken cancellationToken = default);
    
    Task UpdateStudent(StudentUpdateModel studentCreateModel,
        CancellationToken cancellationToken = default);
    
    Task DelStudent(int studentId,
        CancellationToken cancellationToken = default);
    
    Task<StudentViewModel> RemoveParent(int studentId, int parentId,
        CancellationToken cancellationToken = default);
    
}
