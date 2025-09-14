using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesTerritoryHistory
    : EntityBase
{
    public SalesTerritoryHistory()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public int TerritoryID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual SalesPerson SalesPerson { get; set; } = null!;

    public virtual SalesTerritory SalesTerritory { get; set; } = null!;

    #endregion

}
