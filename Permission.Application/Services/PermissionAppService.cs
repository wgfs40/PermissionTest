using AutoMapper;
using Permission.Application.Interfaces;
using Permission.Application.ViewModels;
using Permission.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using permit = Permission.Domain.Models;

namespace Permission.Application.Services
{
    public class PermissionAppService : IPermissionAppService
    {
        private readonly IMapper _mapper;
        private readonly IPermissionRespository _permissionRespository;

        public PermissionAppService(IPermissionRespository permissionRespository, IMapper mapper)
        {
            _permissionRespository = permissionRespository;
            _mapper = mapper;
        }

        public IEnumerable<PermissionViewModel> GetAll()
        {
            var permissions = _permissionRespository.GetAll().ToList();
            var mapPermission = _mapper.Map<List<PermissionViewModel>>(permissions);
            return mapPermission;
        }

        public PermissionViewModel GetById(int id)
        {
            return _mapper.Map<PermissionViewModel>(_permissionRespository.GetById(id));
        }

        public void Register(PermissionViewModel permissionViewModel)
        {
            var mapPermission = _mapper.Map<permit.Permission>(permissionViewModel);
            _permissionRespository.Add(mapPermission);
            _permissionRespository.SaveChanges();
        }

        public void Remove(int id)
        {            
            _permissionRespository.Remove(id);
            _permissionRespository.SaveChanges();
        }

        public void Update(PermissionViewModel permissionViewModel)
        {

            var propertyChanged = false;

            var permission = _permissionRespository.GetById(permissionViewModel.Id);

            if (permission.EmployeeName != permissionViewModel.EmployeeName)
            {
                permission.ChangeEmployeeName(permissionViewModel.EmployeeName);
                propertyChanged = true;
            }

            if (permission.LastNameEmployee != permissionViewModel.LastNameEmployee)
            {
                permission.ChangeLastNameEmployee(permissionViewModel.LastNameEmployee);
                propertyChanged = true;
            }

            if (permission.PermissionTypeId != permissionViewModel.PermissionTypeId)
            {
                permission.ChangePermissionTypeId(permissionViewModel.PermissionTypeId);
                propertyChanged = true;
            }

            if (permission.PermitDate != permissionViewModel.PermitDate)
            {
                permission.ChangePermitDate(permissionViewModel.PermitDate);
                propertyChanged = true;
            }

            if (propertyChanged)
            {
                _permissionRespository.Update(permission);
                _permissionRespository.SaveChanges();
            }
        }
    }
}
