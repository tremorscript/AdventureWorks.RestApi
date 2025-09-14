using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class CreditCard
    : EntityBase
{
    public CreditCard()
    {
        #region Generated Constructor
        PersonCreditCards = new HashSet<PersonCreditCard>();
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        #endregion
    }

    #region Generated Properties
    public int CreditCardID { get; set; }

    public string CardType { get; set; } = null!;

    public string CardNumber { get; set; } = null!;

    public byte ExpMonth { get; set; }

    public short ExpYear { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    #endregion

}
