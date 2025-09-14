using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class BillOfMaterials
    : EntityBase
{
    public BillOfMaterials()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int BillOfMaterialsID { get; set; }

    public int? ProductAssemblyID { get; set; }

    public int ComponentID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string UnitMeasureCode { get; set; } = null!;

    public short BOMLevel { get; set; }

    public decimal PerAssemblyQty { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Product? AssemblyProduct { get; set; }

    public virtual Product ComponentProduct { get; set; } = null!;

    public virtual UnitMeasure UnitMeasure { get; set; } = null!;

    #endregion

}
