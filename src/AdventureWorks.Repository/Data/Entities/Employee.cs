using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Employee
    : EntityBase
{
    public Employee()
    {
        #region Generated Constructor
        EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        EmployeePayHistories = new HashSet<EmployeePayHistory>();
        JobCandidates = new HashSet<JobCandidate>();
        OwnerDocuments = new HashSet<Document>();
        PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public string NationalIDNumber { get; set; } = null!;

    public string LoginID { get; set; } = null!;

    public short? OrganizationLevel { get; set; }

    public string JobTitle { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public string MaritalStatus { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateOnly HireDate { get; set; }

    public bool SalariedFlag { get; set; }

    public short VacationHours { get; set; }

    public short SickLeaveHours { get; set; }

    public bool CurrentFlag { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

    public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }

    public virtual ICollection<JobCandidate> JobCandidates { get; set; }

    public virtual ICollection<Document> OwnerDocuments { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

    public virtual SalesPerson SalesPerson { get; set; } = null!;

    #endregion

}
