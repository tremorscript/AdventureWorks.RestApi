using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VSalesPerson"/> .
/// </summary>
public partial class VSalesPersonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VSalesPersonProfile"/> class.
    /// </summary>
    public VSalesPersonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VSalesPerson, AdventureWorks.Repository.Domain.Models.VSalesPersonModel>();

    }

}
