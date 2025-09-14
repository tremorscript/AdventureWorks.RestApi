using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Shift
    : EntityBase
{
    public Shift()
    {
        #region Generated Constructor
        EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        #endregion
    }

    #region Generated Properties
    public byte ShiftID { get; set; }

    public string Name { get; set; } = null!;

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    #endregion

}
