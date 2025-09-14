using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VJobCandidate"/> .
/// </summary>
public partial class VJobCandidateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateProfile"/> class.
    /// </summary>
    public VJobCandidateProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidate, AdventureWorks.Repository.Domain.Models.VJobCandidateModel>();

    }

}
