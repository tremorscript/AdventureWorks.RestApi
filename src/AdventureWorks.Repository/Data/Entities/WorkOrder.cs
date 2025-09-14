using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class WorkOrder
    : EntityBase
{
    public WorkOrder()
    {
        #region Generated Constructor
        WorkOrderRoutings = new HashSet<WorkOrderRouting>();
        #endregion
    }

    #region Generated Properties
    public int WorkOrderID { get; set; }

    public int ProductID { get; set; }

    public int OrderQty { get; set; }

    public int StockedQty { get; set; }

    public short ScrappedQty { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime DueDate { get; set; }

    public short? ScrapReasonID { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    public virtual ScrapReason? ScrapReason { get; set; }

    public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

    #endregion

}
