using System;
using System.ComponentModel.DataAnnotations;

namespace Permission.Application.ViewModels
{
    public class PermissionViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The EmployeeName is Required")]
        public string EmployeeName { get;  set; }
        [Required(ErrorMessage = "The LastNameEmployee is Required")]
        public string LastNameEmployee { get;  set; }
        [Required(ErrorMessage = "The PermissionTypeId is Required")]
        public int PermissionTypeId { get;  set; }

        [Required(ErrorMessage = "The PermitDate is Required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime PermitDate { get;  set; }
    }
}
