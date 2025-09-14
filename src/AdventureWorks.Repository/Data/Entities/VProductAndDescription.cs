using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VProductAndDescription
    : EntityBase
{
    public VProductAndDescription()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductID { get; set; }

    public string Name { get; set; } = null!;

    public string ProductModel { get; set; } = null!;

    public string CultureID { get; set; } = null!;

    public string Description { get; set; } = null!;

    #endregion

    #region Generated Relationships
    #endregion

}
