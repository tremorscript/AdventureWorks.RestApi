using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesOrderHeaderSalesReason
    : EntityBase
{
    public SalesOrderHeaderSalesReason()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int SalesOrderID { get; set; }

    public int SalesReasonID { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual SalesOrderHeader SalesOrderHeader { get; set; } = null!;

    public virtual SalesReason SalesReason { get; set; } = null!;

    #endregion

}
