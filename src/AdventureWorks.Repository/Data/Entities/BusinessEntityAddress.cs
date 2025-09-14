using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class BusinessEntityAddress
    : EntityBase
{
    public BusinessEntityAddress()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public int AddressID { get; set; }

    public int AddressTypeID { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Address Address { get; set; } = null!;

    public virtual AddressType AddressType { get; set; } = null!;

    public virtual BusinessEntity BusinessEntity { get; set; } = null!;

    #endregion

}
