using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductSubcategory
    : EntityBase
{
    public ProductSubcategory()
    {
        #region Generated Constructor
        Products = new HashSet<Product>();
        #endregion
    }

    #region Generated Properties
    public int ProductSubcategoryID { get; set; }

    public int ProductCategoryID { get; set; }

    public string Name { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ProductCategory ProductCategory { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; }

    #endregion

}
