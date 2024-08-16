using System.Net.Http.Json;
using PSchool.Client.Models;
using PSchool.Client.Services.Interfaces;

namespace PSchool.Client.Services;

public class ParentService(HttpClient httpClient) : IParentService
{
    public async Task<ParentViewModel> GetParents(int parentId, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"http://localhost:5180/api/parent/{parentId}";
        var parent = await httpClient.GetFromJsonAsync<ParentViewModel>(urlRequest, cancellationToken: cancellationToken);
        return parent!;
    }

    public async Task<PaginationResponse<ParentViewModel>> GetParents(PaginationRequest paginationRequest, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"http://localhost:5180/api/parent?CurrentPage={paginationRequest.CurrentPage}&PageSize={paginationRequest.PageSize}";
        var parent = await httpClient.GetFromJsonAsync<PaginationResponse<ParentViewModel>>(urlRequest, cancellationToken: cancellationToken);
        return parent!;
    }

    public async Task CreateParent(ParentCreateModel parentCreateModel, CancellationToken cancellationToken = default)
    {
        const string urlRequest = $"http://localhost:5180/api/parent";
        await httpClient.PostAsJsonAsync(urlRequest, parentCreateModel, cancellationToken);
    }

    public async Task UpdateParent(ParentUpdateModel parentUpdateModel, CancellationToken cancellationToken = default)
    {
        const string urlRequest = $"http://localhost:5180/api/parent";
        await httpClient.PutAsJsonAsync(urlRequest, parentUpdateModel, cancellationToken);
    }

    public async Task DeleteParent(int parentId, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"http://localhost:5180/api/parent/{parentId}";
        await httpClient.DeleteAsync(urlRequest, cancellationToken: cancellationToken);
    }
}