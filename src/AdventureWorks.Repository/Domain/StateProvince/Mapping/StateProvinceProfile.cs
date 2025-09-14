using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="StateProvince"/> .
/// </summary>
public partial class StateProvinceProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StateProvinceProfile"/> class.
    /// </summary>
    public StateProvinceProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.StateProvince, AdventureWorks.Repository.Domain.Models.StateProvinceModel>();

    }

}
