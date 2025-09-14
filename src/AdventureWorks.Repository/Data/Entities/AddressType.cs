using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class AddressType
    : EntityBase
{
    public AddressType()
    {
        #region Generated Constructor
        BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
        #endregion
    }

    #region Generated Properties
    public int AddressTypeID { get; set; }

    public string Name { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

    #endregion

}
