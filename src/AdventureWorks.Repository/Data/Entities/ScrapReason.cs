using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ScrapReason
    : EntityBase
{
    public ScrapReason()
    {
        #region Generated Constructor
        WorkOrders = new HashSet<WorkOrder>();
        #endregion
    }

    #region Generated Properties
    public short ScrapReasonID { get; set; }

    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<WorkOrder> WorkOrders { get; set; }

    #endregion

}
