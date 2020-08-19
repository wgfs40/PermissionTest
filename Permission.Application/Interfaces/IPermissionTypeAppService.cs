using Permission.Application.ViewModels;
using System.Collections.Generic;

namespace Permission.Application.Interfaces
{
    public interface IPermissionTypeAppService
    {
        IEnumerable<PermissionTypeViewModel> GetAll();
    }
}
