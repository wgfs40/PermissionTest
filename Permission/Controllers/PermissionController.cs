using Microsoft.AspNetCore.Mvc;
using Permission.Application.Interfaces;
using Permission.Application.ViewModels;

namespace Permission.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionAppService _permissionAppService;
        public PermissionController(IPermissionAppService permissionAppService)
        {
            _permissionAppService = permissionAppService;
        }

        [HttpGet("getAllPermissions")]
        public IActionResult GetAllPermission()
        {
            var permission = _permissionAppService.GetAll();
            return Ok(permission);
        }

        [HttpGet("getPermissions")]
        public IActionResult GetPermission(int id)
        {
            var permission = _permissionAppService.GetById(id);
            return Ok(permission);
        }

        [HttpPost("registerPermission")]
        public IActionResult Register([FromBody]PermissionViewModel permissionViewModel)
        {
            _permissionAppService.Register(permissionViewModel);
            return Ok("Permission registered");
        }

        [HttpPut("updatePermission")]
        public IActionResult Update([FromBody] PermissionViewModel permissionViewModel)
        {
            _permissionAppService.Update(permissionViewModel);
            return Ok("Permission updated");
        }

        [HttpDelete("deletePermission")]
        public IActionResult Delete(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest("Id is required.");
            }
            _permissionAppService.Remove(Id);
            return Ok("Permission deleted");
        }
    }
}
