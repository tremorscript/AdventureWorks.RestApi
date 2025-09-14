using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesTerritory"/> .
/// </summary>
public partial class SalesTerritoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTerritoryProfile"/> class.
    /// </summary>
    public SalesTerritoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesTerritory, AdventureWorks.Repository.Domain.Models.SalesTerritoryModel>();

    }

}
