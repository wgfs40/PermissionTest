using System.Collections.Generic;

namespace Permission.Domain.Models
{
    public class PermissionType
    {
        #region Contructor
        public PermissionType(string description)
        {
            Description = description;
        }
        #endregion

        #region Properties
        public int Id { get; private set; }
        public string Description { get; private set; }
        #endregion

        #region Association
        public List<Permission> Permissions { get; }
        #endregion

        #region Change
        public PermissionType ChangeDescription(string description)
        {
            Description = description;
            return this;
        }
        #endregion
    }
}
