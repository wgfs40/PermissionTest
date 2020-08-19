using AutoMapper;
using Permission.Application.ViewModels;
using permit = Permission.Domain.Models;

namespace Permission.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PermissionViewModel, permit.Permission>()
                .ConstructUsing(c => new permit.Permission(c.EmployeeName,c.LastNameEmployee,c.PermissionTypeId,c.PermitDate)); ;
        }
    }
}
