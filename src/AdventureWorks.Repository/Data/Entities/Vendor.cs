using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Vendor
    : EntityBase
{
    public Vendor()
    {
        #region Generated Constructor
        ProductVendors = new HashSet<ProductVendor>();
        PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte CreditRating { get; set; }

    public bool PreferredVendorStatus { get; set; }

    public bool ActiveFlag { get; set; }

    public string? PurchasingWebServiceURL { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual BusinessEntity BusinessEntity { get; set; } = null!;

    public virtual ICollection<ProductVendor> ProductVendors { get; set; }

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

    #endregion

}
