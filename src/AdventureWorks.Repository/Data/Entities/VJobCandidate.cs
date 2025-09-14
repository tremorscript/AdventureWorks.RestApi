using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class VJobCandidate
    : EntityBase
{
    public VJobCandidate()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int JobCandidateID { get; set; }

    public int? BusinessEntityID { get; set; }

    public string? NamePrefix { get; set; }

    public string? NameFirst { get; set; }

    public string? NameMiddle { get; set; }

    public string? NameLast { get; set; }

    public string? NameSuffix { get; set; }

    public string? Skills { get; set; }

    public string? AddrType { get; set; }

    public string? AddrLocCountryRegion { get; set; }

    public string? AddrLocState { get; set; }

    public string? AddrLocCity { get; set; }

    public string? AddrPostalCode { get; set; }

    public string? EMail { get; set; }

    public string? WebSite { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
