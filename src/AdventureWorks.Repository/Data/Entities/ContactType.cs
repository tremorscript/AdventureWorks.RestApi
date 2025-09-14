using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ContactType
    : EntityBase
{
    public ContactType()
    {
        #region Generated Constructor
        BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        #endregion
    }

    #region Generated Properties
    public int ContactTypeID { get; set; }

    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

    #endregion

}
