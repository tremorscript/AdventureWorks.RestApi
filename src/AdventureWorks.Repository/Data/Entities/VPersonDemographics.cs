using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VPersonDemographics
    : EntityBase
{
    public VPersonDemographics()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public decimal? TotalPurchaseYTD { get; set; }

    public DateTime? DateFirstPurchase { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? MaritalStatus { get; set; }

    public string? YearlyIncome { get; set; }

    public string? Gender { get; set; }

    public int? TotalChildren { get; set; }

    public int? NumberChildrenAtHome { get; set; }

    public string? Education { get; set; }

    public string? Occupation { get; set; }

    public bool? HomeOwnerFlag { get; set; }

    public int? NumberCarsOwned { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
