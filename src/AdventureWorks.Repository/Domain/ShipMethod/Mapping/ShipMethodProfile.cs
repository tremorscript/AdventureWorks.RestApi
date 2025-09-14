using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ShipMethod"/> .
/// </summary>
public partial class ShipMethodProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShipMethodProfile"/> class.
    /// </summary>
    public ShipMethodProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ShipMethod, AdventureWorks.Repository.Domain.Models.ShipMethodModel>();

    }

}
