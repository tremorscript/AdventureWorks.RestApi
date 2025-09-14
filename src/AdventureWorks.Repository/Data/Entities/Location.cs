using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Location
    : EntityBase
{
    public Location()
    {
        #region Generated Constructor
        ProductInventories = new HashSet<ProductInventory>();
        WorkOrderRoutings = new HashSet<WorkOrderRouting>();
        #endregion
    }

    #region Generated Properties
    public short LocationID { get; set; }

    public string Name { get; set; } = null!;

    public decimal CostRate { get; set; }

    public decimal Availability { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<ProductInventory> ProductInventories { get; set; }

    public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

    #endregion

}
