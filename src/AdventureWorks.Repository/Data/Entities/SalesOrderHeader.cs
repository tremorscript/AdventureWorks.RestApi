using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class SalesOrderHeader
    : EntityBase
{
    public SalesOrderHeader()
    {
        #region Generated Constructor
        SalesOrderDetails = new HashSet<SalesOrderDetail>();
        SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
        #endregion
    }

    #region Generated Properties
    public int SalesOrderID { get; set; }

    public byte RevisionNumber { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? ShipDate { get; set; }

    public byte Status { get; set; }

    public bool OnlineOrderFlag { get; set; }

    public string SalesOrderNumber { get; set; } = null!;

    public string? PurchaseOrderNumber { get; set; }

    public string? AccountNumber { get; set; }

    public int CustomerID { get; set; }

    public int? SalesPersonID { get; set; }

    public int? TerritoryID { get; set; }

    public int BillToAddressID { get; set; }

    public int ShipToAddressID { get; set; }

    public int ShipMethodID { get; set; }

    public int? CreditCardID { get; set; }

    public string? CreditCardApprovalCode { get; set; }

    public int? CurrencyRateID { get; set; }

    public decimal SubTotal { get; set; }

    public decimal TaxAmt { get; set; }

    public decimal Freight { get; set; }

    public decimal TotalDue { get; set; }

    public string? Comment { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Address BillToAddress { get; set; } = null!;

    public virtual CreditCard? CreditCard { get; set; }

    public virtual CurrencyRate? CurrencyRate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

    public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

    public virtual SalesPerson? SalesPerson { get; set; }

    public virtual SalesTerritory? SalesTerritory { get; set; }

    public virtual ShipMethod ShipMethod { get; set; } = null!;

    public virtual Address ShipToAddress { get; set; } = null!;

    #endregion

}
