using AutoMapper;
using PSchool.Client.Models;

namespace PSchool.Client.MapperConfiguration;

public class MapperConfiguration : Profile
{
    public MapperConfiguration()
    {
        CreateMap<StudentUpdateModel, StudentViewModel>().ReverseMap();
        CreateMap<StudentCreateModel, StudentViewModel>().ReverseMap();
        
        
        CreateMap<ParentUpdateModel, ParentViewModel>().ReverseMap();
    }
}