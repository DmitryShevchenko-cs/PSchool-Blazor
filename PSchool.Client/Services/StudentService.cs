using System.Net.Http.Json;
using PSchool.Client.Models;
using PSchool.Client.Services.Interfaces;

namespace PSchool.Client.Services;

public class StudentService(HttpClient httpClient) : IStudentService
{
    public async Task<PaginationResponse<StudentViewModel>> GetStudents(PaginationRequest paginationRequest, string parentName = null!,
        CancellationToken cancellationToken = default)
    {
        var url = $"student?CurrentPage={paginationRequest.CurrentPage}&PageSize={paginationRequest.PageSize}";
        url += string.IsNullOrEmpty(parentName) ? "" : $"&parentName={parentName}";
        var students = await httpClient.GetFromJsonAsync<PaginationResponse<StudentViewModel>>(url, cancellationToken: cancellationToken);
        return students!;
    }

    public async Task<StudentViewModel> GetStudents(int studentId, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"student/{studentId}";
        var students = await httpClient.GetFromJsonAsync<StudentViewModel>(urlRequest, cancellationToken: cancellationToken);
        return students!;
    }

    public async Task PostStudent(StudentCreateModel studentCreateModel, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"student";
        await httpClient.PostAsJsonAsync(urlRequest, studentCreateModel, cancellationToken: cancellationToken);
    }

    public async Task UpdateStudent(StudentUpdateModel studentCreateModel, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"student";
        await httpClient.PutAsJsonAsync(urlRequest, studentCreateModel, cancellationToken: cancellationToken);
    }

    public async Task DelStudent(int studentId, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"student/{studentId}";
        await httpClient.DeleteAsync(urlRequest, cancellationToken: cancellationToken);
    }

    public async Task RemoveParent(int studentId, int parentId, CancellationToken cancellationToken = default)
    { 
        var urlRequest = $"student/parent?studentId={studentId}&parentId={parentId}";
        await httpClient.DeleteAsync(urlRequest, cancellationToken: cancellationToken);
    }
}