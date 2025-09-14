using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class PhoneNumberType
    : EntityBase
{
    public PhoneNumberType()
    {
        #region Generated Constructor
        PersonPhones = new HashSet<PersonPhone>();
        #endregion
    }

    #region Generated Properties
    public int PhoneNumberTypeID { get; set; }

    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<PersonPhone> PersonPhones { get; set; }

    #endregion

}
