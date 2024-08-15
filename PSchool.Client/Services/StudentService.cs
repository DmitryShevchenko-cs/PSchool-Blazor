using System.Net.Http.Json;
using PSchool.Client.Models;
using PSchool.Client.Services.Interfaces;

namespace PSchool.Client.Services;

public class StudentService(HttpClient httpClient) : IStudentService
{
    public async Task<PaginationResponse<StudentViewModel>> GetStudents(PaginationRequest paginationRequest, string parentName = null!,
        CancellationToken cancellationToken = default)
    {
        var urlRequest = $"http://localhost:5180/api/student?CurrentPage={paginationRequest.CurrentPage}&PageSize={paginationRequest.PageSize}";
        var students = await httpClient.GetFromJsonAsync<PaginationResponse<StudentViewModel>>(urlRequest, cancellationToken: cancellationToken);
        return students!;
    }

    public async Task<StudentViewModel> GetStudents(int studentId, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"http://localhost:5180/api/student/{studentId}";
        var students = await httpClient.GetFromJsonAsync<StudentViewModel>(urlRequest, cancellationToken: cancellationToken);
        return students!;
    }

    public Task<StudentViewModel> PostStudent(StudentCreateModel studentCreateModel, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateStudent(StudentUpdateModel studentCreateModel, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"http://localhost:5180/api/student";
        var students = await httpClient.PutAsJsonAsync(urlRequest, studentCreateModel, cancellationToken: cancellationToken);
    }

    public async Task DelStudent(int studentId, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"http://localhost:5180/api/student/{studentId}";
        var responseMessage = await httpClient.DeleteAsync(urlRequest, cancellationToken: cancellationToken);
    }

    public Task<StudentViewModel> RemoveParent(int studentId, int parentId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}