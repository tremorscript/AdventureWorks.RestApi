using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Store
    : EntityBase
{
    public Store()
    {
        #region Generated Constructor
        Customers = new HashSet<Customer>();
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public string Name { get; set; } = null!;

    public int? SalesPersonID { get; set; }

    public string? Demographics { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual BusinessEntity BusinessEntity { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; }

    public virtual SalesPerson? SalesPerson { get; set; }

    #endregion

}
