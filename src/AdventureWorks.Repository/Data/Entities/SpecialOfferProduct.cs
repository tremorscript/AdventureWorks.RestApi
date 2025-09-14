using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SpecialOfferProduct
    : EntityBase
{
    public SpecialOfferProduct()
    {
        #region Generated Constructor
        SalesOrderDetails = new HashSet<SalesOrderDetail>();
        #endregion
    }

    #region Generated Properties
    public int SpecialOfferID { get; set; }

    public int ProductID { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

    public virtual SpecialOffer SpecialOffer { get; set; } = null!;

    #endregion

}
