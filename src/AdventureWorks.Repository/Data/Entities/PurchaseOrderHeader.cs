using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class PurchaseOrderHeader
    : EntityBase
{
    public PurchaseOrderHeader()
    {
        #region Generated Constructor
        PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
        #endregion
    }

    #region Generated Properties
    public int PurchaseOrderID { get; set; }

    public byte RevisionNumber { get; set; }

    public byte Status { get; set; }

    public int EmployeeID { get; set; }

    public int VendorID { get; set; }

    public int ShipMethodID { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? ShipDate { get; set; }

    public decimal SubTotal { get; set; }

    public decimal TaxAmt { get; set; }

    public decimal Freight { get; set; }

    public decimal TotalDue { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

    public virtual ShipMethod ShipMethod { get; set; } = null!;

    public virtual Vendor Vendor { get; set; } = null!;

    #endregion

}
