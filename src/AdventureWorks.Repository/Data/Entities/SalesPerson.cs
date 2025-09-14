using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesPerson
    : EntityBase
{
    public SalesPerson()
    {
        #region Generated Constructor
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
        SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
        Stores = new HashSet<Store>();
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public int? TerritoryID { get; set; }

    public decimal? SalesQuota { get; set; }

    public decimal Bonus { get; set; }

    public decimal CommissionPct { get; set; }

    public decimal SalesYTD { get; set; }

    public decimal SalesLastYear { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

    public virtual SalesTerritory? SalesTerritory { get; set; }

    public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

    public virtual ICollection<Store> Stores { get; set; }

    #endregion

}
