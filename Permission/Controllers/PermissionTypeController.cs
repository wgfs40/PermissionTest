using Microsoft.AspNetCore.Mvc;
using Permission.Application.Interfaces;

namespace Permission.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermissionTypeController : ControllerBase
    {
        private readonly IPermissionTypeAppService _permissionTypeAppService;
        public PermissionTypeController(IPermissionTypeAppService permissionTypeAppService)
        {
            _permissionTypeAppService = permissionTypeAppService;
        }

        [HttpGet("getAllPermissionType")]
        public IActionResult GetAllPermissionType()
        {
            var permission = _permissionTypeAppService.GetAll();
            return Ok(permission);
        }
    }
}
