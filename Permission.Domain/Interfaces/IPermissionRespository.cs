using permit = Permission.Domain.Models;
namespace Permission.Domain.Interfaces
{
    public interface IPermissionRespository :IRepository<permit.Permission>
    {
    }
}
