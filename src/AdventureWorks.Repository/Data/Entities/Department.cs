using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Department
    : EntityBase
{
    public Department()
    {
        #region Generated Constructor
        EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        #endregion
    }

    #region Generated Properties
    public short DepartmentID { get; set; }

    public string Name { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    #endregion

}
