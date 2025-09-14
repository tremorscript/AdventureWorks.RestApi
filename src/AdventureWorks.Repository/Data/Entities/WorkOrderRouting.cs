using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class WorkOrderRouting
    : EntityBase
{
    public WorkOrderRouting()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int WorkOrderID { get; set; }

    public int ProductID { get; set; }

    public short OperationSequence { get; set; }

    public short LocationID { get; set; }

    public DateTime ScheduledStartDate { get; set; }

    public DateTime ScheduledEndDate { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public DateTime? ActualEndDate { get; set; }

    public decimal? ActualResourceHrs { get; set; }

    public decimal PlannedCost { get; set; }

    public decimal? ActualCost { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Location Location { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;

    #endregion

}
