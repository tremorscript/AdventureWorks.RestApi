using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Address
    : EntityBase
{
    public Address()
    {
        #region Generated Constructor
        BillToSalesOrderHeaders = new HashSet<SalesOrderHeader>();
        BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
        ShipToSalesOrderHeaders = new HashSet<SalesOrderHeader>();
        #endregion
    }

    #region Generated Properties
    public int AddressID { get; set; }

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = null!;

    public int StateProvinceID { get; set; }

    public string PostalCode { get; set; } = null!;

    public NetTopologySuite.Geometries.Geometry? SpatialLocation { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<SalesOrderHeader> BillToSalesOrderHeaders { get; set; }

    public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

    public virtual ICollection<SalesOrderHeader> ShipToSalesOrderHeaders { get; set; }

    public virtual StateProvince StateProvince { get; set; } = null!;

    #endregion

}
