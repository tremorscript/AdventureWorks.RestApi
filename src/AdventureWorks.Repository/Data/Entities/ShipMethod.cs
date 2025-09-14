using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ShipMethod
    : EntityBase
{
    public ShipMethod()
    {
        #region Generated Constructor
        PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        #endregion
    }

    #region Generated Properties
    public int ShipMethodID { get; set; }

    public string Name { get; set; } = null!;

    public decimal ShipBase { get; set; }

    public decimal ShipRate { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    #endregion

}
