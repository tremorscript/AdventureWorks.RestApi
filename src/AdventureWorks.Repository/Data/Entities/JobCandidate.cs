using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class JobCandidate
    : EntityBase
{
    public JobCandidate()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int JobCandidateID { get; set; }

    public int? BusinessEntityID { get; set; }

    public string? Resume { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Employee? Employee { get; set; }

    #endregion

}
