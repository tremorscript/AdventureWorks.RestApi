using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class PersonPhone
    : EntityBase
{
    public PersonPhone()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public int PhoneNumberTypeID { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Person Person { get; set; } = null!;

    public virtual PhoneNumberType PhoneNumberType { get; set; } = null!;

    #endregion

}
