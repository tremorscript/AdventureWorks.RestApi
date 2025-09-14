using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="UnitMeasure"/> .
/// </summary>
public partial class UnitMeasureProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitMeasureProfile"/> class.
    /// </summary>
    public UnitMeasureProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.UnitMeasure, AdventureWorks.Repository.Domain.Models.UnitMeasureModel>();

    }

}
