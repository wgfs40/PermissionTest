using permit = Permission.Domain.Models;

namespace Permission.Domain.Interfaces
{
    public interface IPermissionTypeRespository : IRepository<permit.PermissionType>
    {
    }
}
