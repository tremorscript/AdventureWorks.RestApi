using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ProductListPriceHistory
    : EntityBase
{
    public ProductListPriceHistory()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal ListPrice { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    #endregion

}
