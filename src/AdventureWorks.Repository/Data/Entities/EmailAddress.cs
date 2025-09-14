using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class EmailAddress
    : EntityBase
{
    public EmailAddress()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public int EmailAddressID { get; set; }

    public string? EmailAddressMember { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Person Person { get; set; } = null!;

    #endregion

}
