using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VAdditionalContactInfo
    : EntityBase
{
    public VAdditionalContactInfo()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? TelephoneNumber { get; set; }

    public string? TelephoneSpecialInstructions { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? StateProvince { get; set; }

    public string? PostalCode { get; set; }

    public string? CountryRegion { get; set; }

    public string? HomeAddressSpecialInstructions { get; set; }

    public string? EMailAddress { get; set; }

    public string? EMailSpecialInstructions { get; set; }

    public string? EMailTelephoneNumber { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
