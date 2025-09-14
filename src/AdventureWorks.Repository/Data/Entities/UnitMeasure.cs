using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class UnitMeasure
    : EntityBase
{
    public UnitMeasure()
    {
        #region Generated Constructor
        BillOfMaterials = new HashSet<BillOfMaterials>();
        ProductVendors = new HashSet<ProductVendor>();
        SizeProducts = new HashSet<Product>();
        WeightProducts = new HashSet<Product>();
        #endregion
    }

    #region Generated Properties
    public string UnitMeasureCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }

    public virtual ICollection<ProductVendor> ProductVendors { get; set; }

    public virtual ICollection<Product> SizeProducts { get; set; }

    public virtual ICollection<Product> WeightProducts { get; set; }

    #endregion

}
