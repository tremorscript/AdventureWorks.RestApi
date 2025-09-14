using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VStoreWithContacts
    : EntityBase
{
    public VStoreWithContacts()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public string Name { get; set; } = null!;

    public string ContactType { get; set; } = null!;

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PhoneNumberType { get; set; }

    public string? EmailAddress { get; set; }

    public int EmailPromotion { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
