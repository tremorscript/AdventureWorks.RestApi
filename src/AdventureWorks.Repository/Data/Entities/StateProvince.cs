using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class StateProvince
    : EntityBase
{
    public StateProvince()
    {
        #region Generated Constructor
        Addresses = new HashSet<Address>();
        SalesTaxRates = new HashSet<SalesTaxRate>();
        #endregion
    }

    #region Generated Properties
    public int StateProvinceID { get; set; }

    public string StateProvinceCode { get; set; } = null!;

    public string CountryRegionCode { get; set; } = null!;

    public bool IsOnlyStateProvinceFlag { get; set; }

    public string Name { get; set; } = null!;

    public int TerritoryID { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Address> Addresses { get; set; }

    public virtual CountryRegion CountryRegion { get; set; } = null!;

    public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }

    public virtual SalesTerritory SalesTerritory { get; set; } = null!;

    #endregion

}
