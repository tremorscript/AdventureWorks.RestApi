using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VJobCandidateEmployment"/> .
/// </summary>
public partial class VJobCandidateEmploymentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VJobCandidateEmploymentProfile"/> class.
    /// </summary>
    public VJobCandidateEmploymentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VJobCandidateEmployment, AdventureWorks.Repository.Domain.Models.VJobCandidateEmploymentModel>();

    }

}
