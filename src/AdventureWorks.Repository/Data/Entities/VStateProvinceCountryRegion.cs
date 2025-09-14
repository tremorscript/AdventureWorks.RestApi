using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VStateProvinceCountryRegion
    : EntityBase
{
    public VStateProvinceCountryRegion()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int StateProvinceID { get; set; }

    public string StateProvinceCode { get; set; } = null!;

    public bool IsOnlyStateProvinceFlag { get; set; }

    public string StateProvinceName { get; set; } = null!;

    public int TerritoryID { get; set; }

    public string CountryRegionCode { get; set; } = null!;

    public string CountryRegionName { get; set; } = null!;

    #endregion

    #region Generated Relationships
    #endregion

}
