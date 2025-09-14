using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Culture
    : EntityBase
{
    public Culture()
    {
        #region Generated Constructor
        ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        #endregion
    }

    #region Generated Properties
    public string CultureID { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

    #endregion

}
