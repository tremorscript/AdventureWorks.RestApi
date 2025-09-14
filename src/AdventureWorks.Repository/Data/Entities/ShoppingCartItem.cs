using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class ShoppingCartItem
    : EntityBase
{
    public ShoppingCartItem()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ShoppingCartItemID { get; set; }

    public string ShoppingCartID { get; set; } = null!;

    public int Quantity { get; set; }

    public int ProductID { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product Product { get; set; } = null!;

    #endregion

}
