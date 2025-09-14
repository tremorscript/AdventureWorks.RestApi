using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStateProvinceCountryRegion"/> .
/// </summary>
public partial class VStateProvinceCountryRegionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStateProvinceCountryRegionProfile"/> class.
    /// </summary>
    public VStateProvinceCountryRegionProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VStateProvinceCountryRegion, AdventureWorks.Repository.Domain.Models.VStateProvinceCountryRegionModel>();

    }

}
