using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SpecialOffer
    : EntityBase
{
    public SpecialOffer()
    {
        #region Generated Constructor
        SpecialOfferProducts = new HashSet<SpecialOfferProduct>();
        #endregion
    }

    #region Generated Properties
    public int SpecialOfferID { get; set; }

    public string Description { get; set; } = null!;

    public decimal DiscountPct { get; set; }

    public string Type { get; set; } = null!;

    public string Category { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int MinQty { get; set; }

    public int? MaxQty { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

    #endregion

}
