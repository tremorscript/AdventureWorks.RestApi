using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class BusinessEntity
    : EntityBase
{
    public BusinessEntity()
    {
        #region Generated Constructor
        BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
        BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

    public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;

    public virtual Vendor Vendor { get; set; } = null!;

    #endregion

}
