using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductProductPhoto
    : EntityBase
{
    public ProductProductPhoto()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductID { get; set; }

    public int ProductPhotoID { get; set; }

    public bool Primary { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    public virtual ProductPhoto ProductPhoto { get; set; } = null!;

    #endregion

}
