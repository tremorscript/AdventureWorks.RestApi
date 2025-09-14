using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class TransactionHistory
    : EntityBase
{
    public TransactionHistory()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int TransactionID { get; set; }

    public int ProductID { get; set; }

    public int ReferenceOrderID { get; set; }

    public int ReferenceOrderLineID { get; set; }

    public DateTime TransactionDate { get; set; }

    public string TransactionType { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal ActualCost { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    #endregion

}
