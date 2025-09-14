using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class CountryRegionCurrency
    : EntityBase
{
    public CountryRegionCurrency()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public string CountryRegionCode { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual CountryRegion CountryRegion { get; set; } = null!;

    public virtual Currency Currency { get; set; } = null!;

    #endregion

}
