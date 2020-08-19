using AutoMapper;
using Permission.Application.Interfaces;
using Permission.Application.ViewModels;
using Permission.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Permission.Application.Services
{
    public class PermissionTypeAppService : IPermissionTypeAppService
    {
        private readonly IMapper _mapper;
        private readonly IPermissionTypeRespository _permissionTypeRespository;

        public PermissionTypeAppService(IMapper mapper, IPermissionTypeRespository permissionTypeRespository)
        {
            _mapper = mapper;
            _permissionTypeRespository = permissionTypeRespository;
        }

        public IEnumerable<PermissionTypeViewModel> GetAll()
        {
            var permissionsType = _permissionTypeRespository.GetAll().ToList();
            var mapPermissionType = _mapper.Map<List<PermissionTypeViewModel>>(permissionsType);
            return mapPermissionType;
        }
    }
}
