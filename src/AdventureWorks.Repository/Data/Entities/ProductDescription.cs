using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductDescription
    : EntityBase
{
    public ProductDescription()
    {
        #region Generated Constructor
        ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        #endregion
    }

    #region Generated Properties
    public int ProductDescriptionID { get; set; }

    public string Description { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    #endregion

}
