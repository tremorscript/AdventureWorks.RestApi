using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductInventory
    : EntityBase
{
    public ProductInventory()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductID { get; set; }

    public short LocationID { get; set; }

    public string Shelf { get; set; } = null!;

    public byte Bin { get; set; }

    public short Quantity { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Location Location { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    #endregion

}
