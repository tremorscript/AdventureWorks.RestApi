using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class PersonCreditCard
    : EntityBase
{
    public PersonCreditCard()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public int CreditCardID { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual CreditCard CreditCard { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    #endregion

}
