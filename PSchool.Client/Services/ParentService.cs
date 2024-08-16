using System.Net.Http.Json;
using System.Text;
using Microsoft.Extensions.Options;
using PSchool.Client.Models;
using PSchool.Client.Services.Interfaces;

namespace PSchool.Client.Services;

public class ParentService(HttpClient httpClient) : IParentService
{
    public async Task<ParentViewModel> GetParents(int parentId, CancellationToken cancellationToken = default)
    {
        
        var url = $"parent/{parentId}";
        var parent = await httpClient.GetFromJsonAsync<ParentViewModel>(url, cancellationToken: cancellationToken);
        return parent!;
    }

    public async Task<PaginationResponse<ParentViewModel>> GetParents(PaginationRequest paginationRequest, CancellationToken cancellationToken = default)
    { 
        var url = $"parent?CurrentPage={paginationRequest.CurrentPage}&PageSize={paginationRequest.PageSize}";
        var parent = await httpClient.GetFromJsonAsync<PaginationResponse<ParentViewModel>>(url, cancellationToken: cancellationToken);
        return parent!;
    }

    public async Task CreateParent(ParentCreateModel parentCreateModel, CancellationToken cancellationToken = default)
    {
        const string urlRequest = $"parent";
        await httpClient.PostAsJsonAsync(urlRequest, parentCreateModel, cancellationToken);
    }

    public async Task UpdateParent(ParentUpdateModel parentUpdateModel, CancellationToken cancellationToken = default)
    {
        const string urlRequest = $"parent";
        await httpClient.PutAsJsonAsync(urlRequest, parentUpdateModel, cancellationToken);
    }

    public async Task DeleteParent(int parentId, CancellationToken cancellationToken = default)
    {
        var urlRequest = $"parent/{parentId}";
        await httpClient.DeleteAsync(urlRequest, cancellationToken: cancellationToken);
    }
}