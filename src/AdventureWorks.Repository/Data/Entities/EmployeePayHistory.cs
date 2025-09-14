using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class EmployeePayHistory
    : EntityBase
{
    public EmployeePayHistory()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public DateTime RateChangeDate { get; set; }

    public decimal Rate { get; set; }

    public byte PayFrequency { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Employee Employee { get; set; } = null!;

    #endregion

}
