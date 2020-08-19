using System.ComponentModel.DataAnnotations;

namespace Permission.Application.ViewModels
{
    public class PermissionTypeViewModel
    {
        public int Id { get; set; }
        [Required( ErrorMessage = "Description is required.")]
        public string Description { get; set; }
    }
}
