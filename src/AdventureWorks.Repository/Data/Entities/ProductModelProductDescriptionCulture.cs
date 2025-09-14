using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductModelProductDescriptionCulture
    : EntityBase
{
    public ProductModelProductDescriptionCulture()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductModelID { get; set; }

    public int ProductDescriptionID { get; set; }

    public string CultureID { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Culture Culture { get; set; } = null!;

    public virtual ProductDescription ProductDescription { get; set; } = null!;

    public virtual ProductModel ProductModel { get; set; } = null!;

    #endregion

}
