using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesReason
    : EntityBase
{
    public SalesReason()
    {
        #region Generated Constructor
        SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
        #endregion
    }

    #region Generated Properties
    public int SalesReasonID { get; set; }

    public string Name { get; set; } = null!;

    public string ReasonType { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

    #endregion

}
