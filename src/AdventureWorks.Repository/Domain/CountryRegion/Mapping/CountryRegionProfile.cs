using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CountryRegion"/> .
/// </summary>
public partial class CountryRegionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionProfile"/> class.
    /// </summary>
    public CountryRegionProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.CountryRegion, AdventureWorks.Repository.Domain.Models.CountryRegionModel>();

    }

}
