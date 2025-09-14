using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductModel
    : EntityBase
{
    public ProductModel()
    {
        #region Generated Constructor
        ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        Products = new HashSet<Product>();
        #endregion
    }

    #region Generated Properties
    public int ProductModelID { get; set; }

    public string Name { get; set; } = null!;

    public string? CatalogDescription { get; set; }

    public string? Instructions { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

    public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    public virtual ICollection<Product> Products { get; set; }

    #endregion

}
