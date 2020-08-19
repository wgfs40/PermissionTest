using Permission.Database.Context;
using Permission.Domain.Interfaces;
using permit = Permission.Domain.Models;

namespace Permission.Database.Repository
{
    public class PermissionTypeRespository: Repository<permit.PermissionType>, IPermissionTypeRespository
    {
        public PermissionTypeRespository(PermissionContext permissionContext): base(permissionContext)
        {

        }
    }
}
