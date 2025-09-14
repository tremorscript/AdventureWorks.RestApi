using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductCategory
    : EntityBase
{
    public ProductCategory()
    {
        #region Generated Constructor
        ProductSubcategories = new HashSet<ProductSubcategory>();
        #endregion
    }

    #region Generated Properties
    public int ProductCategoryID { get; set; }

    public string Name { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }

    #endregion

}
