using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VProductModelInstructions
    : EntityBase
{
    public VProductModelInstructions()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int ProductModelID { get; set; }

    public string Name { get; set; } = null!;

    public string? Instructions { get; set; }

    public int? LocationID { get; set; }

    public decimal? SetupHours { get; set; }

    public decimal? MachineHours { get; set; }

    public decimal? LaborHours { get; set; }

    public int? LotSize { get; set; }

    public string? Step { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
