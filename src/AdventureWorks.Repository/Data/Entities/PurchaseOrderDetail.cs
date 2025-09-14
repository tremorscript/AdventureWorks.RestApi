using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class PurchaseOrderDetail
    : EntityBase
{
    public PurchaseOrderDetail()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int PurchaseOrderID { get; set; }

    public int PurchaseOrderDetailID { get; set; }

    public DateTime DueDate { get; set; }

    public short OrderQty { get; set; }

    public int ProductID { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal LineTotal { get; set; }

    public decimal ReceivedQty { get; set; }

    public decimal RejectedQty { get; set; }

    public decimal StockedQty { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; } = null!;

    #endregion

}
