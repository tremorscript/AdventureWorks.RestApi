using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VJobCandidateEmployment
    : EntityBase
{
    public VJobCandidateEmployment()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int JobCandidateID { get; set; }

    public DateTime? EmpStartDate { get; set; }

    public DateTime? EmpEndDate { get; set; }

    public string? EmpOrgName { get; set; }

    public string? EmpJobTitle { get; set; }

    public string? EmpResponsibility { get; set; }

    public string? EmpFunctionCategory { get; set; }

    public string? EmpIndustryCategory { get; set; }

    public string? EmpLocCountryRegion { get; set; }

    public string? EmpLocState { get; set; }

    public string? EmpLocCity { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
