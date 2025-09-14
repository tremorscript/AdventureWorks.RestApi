using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="JobCandidate"/> .
/// </summary>
public partial class JobCandidateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JobCandidateProfile"/> class.
    /// </summary>
    public JobCandidateProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.JobCandidate, AdventureWorks.Repository.Domain.Models.JobCandidateModel>();

    }

}
