using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesTerritory
    : EntityBase
{
    public SalesTerritory()
    {
        #region Generated Constructor
        Customers = new HashSet<Customer>();
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        SalesPeople = new HashSet<SalesPerson>();
        SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
        StateProvinces = new HashSet<StateProvince>();
        #endregion
    }

    #region Generated Properties
    public int TerritoryID { get; set; }

    public string Name { get; set; } = null!;

    public string CountryRegionCode { get; set; } = null!;

    public string Group { get; set; } = null!;

    public decimal SalesYTD { get; set; }

    public decimal SalesLastYear { get; set; }

    public decimal CostYTD { get; set; }

    public decimal CostLastYear { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual CountryRegion CountryRegion { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; }

    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    public virtual ICollection<SalesPerson> SalesPeople { get; set; }

    public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

    public virtual ICollection<StateProvince> StateProvinces { get; set; }

    #endregion

}
