using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesPersonQuotaHistory
    : EntityBase
{
    public SalesPersonQuotaHistory()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public DateTime QuotaDate { get; set; }

    public decimal SalesQuota { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual SalesPerson SalesPerson { get; set; } = null!;

    #endregion

}
