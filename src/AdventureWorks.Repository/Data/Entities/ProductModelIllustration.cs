using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductModelIllustration
    : EntityBase
{
    public ProductModelIllustration()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductModelID { get; set; }

    public int IllustrationID { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Illustration Illustration { get; set; } = null!;

    public virtual ProductModel ProductModel { get; set; } = null!;

    #endregion

}
