using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductReview
    : EntityBase
{
    public ProductReview()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductReviewID { get; set; }

    public int ProductID { get; set; }

    public string ReviewerName { get; set; } = null!;

    public DateTime ReviewDate { get; set; }

    public string EmailAddress { get; set; } = null!;

    public int Rating { get; set; }

    public string? Comments { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    #endregion

}
