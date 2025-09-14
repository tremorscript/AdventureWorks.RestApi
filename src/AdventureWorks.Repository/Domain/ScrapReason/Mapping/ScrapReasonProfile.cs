using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ScrapReason"/> .
/// </summary>
public partial class ScrapReasonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScrapReasonProfile"/> class.
    /// </summary>
    public ScrapReasonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ScrapReason, AdventureWorks.Repository.Domain.Models.ScrapReasonModel>();

    }

}
