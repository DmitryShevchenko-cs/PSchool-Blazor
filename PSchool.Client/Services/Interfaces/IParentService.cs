using PSchool.Client.Models;

namespace PSchool.Client.Services.Interfaces;

public interface IParentService
{
    Task<ParentViewModel> GetParents(int parentId, CancellationToken cancellationToken = default);

    Task CreateParent(ParentCreateModel parentCreateModel,
        CancellationToken cancellationToken = default);
}