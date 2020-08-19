using AutoMapper;
using Permission.Application.ViewModels;
using permit = Permission.Domain.Models;

namespace Permission.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<permit.Permission, PermissionViewModel>();
            CreateMap<permit.PermissionType, PermissionTypeViewModel>();
        }
    }
}
