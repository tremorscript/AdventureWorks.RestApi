using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Illustration
    : EntityBase
{
    public Illustration()
    {
        #region Generated Constructor
        ProductModelIllustrations = new HashSet<ProductModelIllustration>();
        #endregion
    }

    #region Generated Properties
    public int IllustrationID { get; set; }

    public string? Diagram { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

    #endregion

}
