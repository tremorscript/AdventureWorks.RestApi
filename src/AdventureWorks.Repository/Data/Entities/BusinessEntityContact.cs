using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class BusinessEntityContact
    : EntityBase
{
    public BusinessEntityContact()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public int PersonID { get; set; }

    public int ContactTypeID { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual BusinessEntity BusinessEntity { get; set; } = null!;

    public virtual ContactType ContactType { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    #endregion

}
