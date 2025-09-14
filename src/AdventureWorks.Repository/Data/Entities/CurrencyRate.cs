using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class CurrencyRate
    : EntityBase
{
    public CurrencyRate()
    {
        #region Generated Constructor
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        #endregion
    }

    #region Generated Properties
    public int CurrencyRateID { get; set; }

    public DateTime CurrencyRateDate { get; set; }

    public string FromCurrencyCode { get; set; } = null!;

    public string ToCurrencyCode { get; set; } = null!;

    public decimal AverageRate { get; set; }

    public decimal EndOfDayRate { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Currency FromCurrency { get; set; } = null!;

    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    public virtual Currency ToCurrency { get; set; } = null!;

    #endregion

}
