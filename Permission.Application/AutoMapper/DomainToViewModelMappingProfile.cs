using AutoMapper;
using Permission.Application.ViewModels;
using permit = Permission.Domain.Models;

namespace Permission.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<permit.Permission, PermissionViewModel>()
                .ForMember(p => p.PermissionTypeDescripcion,model => model.MapFrom(vModel => vModel.PermissionType.Description));
            CreateMap<permit.PermissionType, PermissionTypeViewModel>();
        }
    }
}
