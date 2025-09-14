using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Customer
    : EntityBase
{
    public Customer()
    {
        #region Generated Constructor
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        #endregion
    }

    #region Generated Properties
    public int CustomerID { get; set; }

    public int? PersonID { get; set; }

    public int? StoreID { get; set; }

    public int? TerritoryID { get; set; }

    public string AccountNumber { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Person? Person { get; set; }

    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    public virtual SalesTerritory? SalesTerritory { get; set; }

    public virtual Store? Store { get; set; }

    #endregion

}
