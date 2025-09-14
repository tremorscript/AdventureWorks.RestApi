using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesOrderDetail
    : EntityBase
{
    public SalesOrderDetail()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int SalesOrderID { get; set; }

    public int SalesOrderDetailID { get; set; }

    public string? CarrierTrackingNumber { get; set; }

    public short OrderQty { get; set; }

    public int ProductID { get; set; }

    public int SpecialOfferID { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal UnitPriceDiscount { get; set; }

    public decimal LineTotal { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual SalesOrderHeader SalesOrderHeader { get; set; } = null!;

    public virtual SpecialOfferProduct SpecialOfferProduct { get; set; } = null!;

    #endregion

}
