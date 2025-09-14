using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductVendor
    : EntityBase
{
    public ProductVendor()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductID { get; set; }

    public int BusinessEntityID { get; set; }

    public int AverageLeadTime { get; set; }

    public decimal StandardPrice { get; set; }

    public decimal? LastReceiptCost { get; set; }

    public DateTime? LastReceiptDate { get; set; }

    public int MinOrderQty { get; set; }

    public int MaxOrderQty { get; set; }

    public int? OnOrderQty { get; set; }

    public string UnitMeasureCode { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    public virtual UnitMeasure UnitMeasure { get; set; } = null!;

    public virtual Vendor Vendor { get; set; } = null!;

    #endregion

}
