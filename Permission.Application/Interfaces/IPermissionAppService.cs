using Permission.Application.ViewModels;
using System.Collections.Generic;

namespace Permission.Application.Interfaces
{
    public interface IPermissionAppService
    {
        void Register(PermissionViewModel permissionViewModel);
        IEnumerable<PermissionViewModel> GetAll();
        PermissionViewModel GetById(int id);
        void Update(PermissionViewModel permissionViewModel);
        void Remove(int id);
    }
}
