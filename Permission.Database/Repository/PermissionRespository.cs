using Permission.Database.Context;
using Permission.Domain.Interfaces;
using permit = Permission.Domain.Models;
namespace Permission.Database.Repository
{
    public class PermissionRespository : Repository<permit.Permission>, IPermissionRespository
    {
        public PermissionRespository(PermissionContext permissionContext): base(permissionContext)
        {

        }
    }
}
