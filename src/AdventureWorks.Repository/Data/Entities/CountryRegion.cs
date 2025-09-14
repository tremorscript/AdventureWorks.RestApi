using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class CountryRegion
    : EntityBase
{
    public CountryRegion()
    {
        #region Generated Constructor
        CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
        SalesTerritories = new HashSet<SalesTerritory>();
        StateProvinces = new HashSet<StateProvince>();
        #endregion
    }

    #region Generated Properties
    public string CountryRegionCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

    public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }

    public virtual ICollection<StateProvince> StateProvinces { get; set; }

    #endregion

}
