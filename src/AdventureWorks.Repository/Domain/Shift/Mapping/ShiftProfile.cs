using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Shift"/> .
/// </summary>
public partial class ShiftProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftProfile"/> class.
    /// </summary>
    public ShiftProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Shift, AdventureWorks.Repository.Domain.Models.ShiftModel>();

    }

}
