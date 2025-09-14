using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VJobCandidateEducation
    : EntityBase
{
    public VJobCandidateEducation()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int JobCandidateID { get; set; }

    public string? EduLevel { get; set; }

    public DateTime? EduStartDate { get; set; }

    public DateTime? EduEndDate { get; set; }

    public string? EduDegree { get; set; }

    public string? EduMajor { get; set; }

    public string? EduMinor { get; set; }

    public string? EduGPA { get; set; }

    public string? EduGPAScale { get; set; }

    public string? EduSchool { get; set; }

    public string? EduLocCountryRegion { get; set; }

    public string? EduLocState { get; set; }

    public string? EduLocCity { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
