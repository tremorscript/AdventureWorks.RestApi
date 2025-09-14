using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VSalesPersonSalesByFiscalYears
    : EntityBase
{
    public VSalesPersonSalesByFiscalYears()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int? SalesPersonID { get; set; }

    public string? FullName { get; set; }

    public string JobTitle { get; set; } = null!;

    public string SalesTerritory { get; set; } = null!;

    public decimal? Number2002 { get; set; }

    public decimal? Number2003 { get; set; }

    public decimal? Number2004 { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
