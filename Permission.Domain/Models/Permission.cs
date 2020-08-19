using System;

namespace Permission.Domain.Models
{
    public class Permission
    {
        #region Contructor
        public Permission(string employeeName, string lastNameEmployee, int permissionTypeId, DateTime permitDate)
        {
            EmployeeName = employeeName;
            LastNameEmployee = lastNameEmployee;
            PermissionTypeId = permissionTypeId;
            PermitDate = permitDate;
        }
        #endregion

        #region Properties
        public int Id { get; }
        public string EmployeeName { get; private set; }
        public string LastNameEmployee { get; private set; }
        public int PermissionTypeId { get; private set; }
        public DateTime PermitDate { get; private set; }
        #endregion

        #region Association
        public PermissionType PermissionType { get; }
        #endregion

        #region Changes
        public Permission ChangeEmployeeName(string employeeName)
        {
            EmployeeName = employeeName;
            return this;
        }

        public Permission ChangeLastNameEmployee(string lastNameEmployee)
        {
            LastNameEmployee = lastNameEmployee;
            return this;
        }

        public Permission ChangePermissionTypeId(int permissionTypeId)
        {
            PermissionTypeId = permissionTypeId;
            return this;
        }

        public Permission ChangePermitDate(DateTime permitDate)
        {
            PermitDate = permitDate;
            return this;
        }
        #endregion

    }
}
