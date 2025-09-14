using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesTaxRate
    : EntityBase
{
    public SalesTaxRate()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int SalesTaxRateID { get; set; }

    public int StateProvinceID { get; set; }

    public byte TaxType { get; set; }

    public decimal TaxRate { get; set; }

    public string Name { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual StateProvince StateProvince { get; set; } = null!;

    #endregion

}
