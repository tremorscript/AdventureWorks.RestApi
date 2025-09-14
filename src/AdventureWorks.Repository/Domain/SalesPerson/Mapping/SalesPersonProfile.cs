using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesPerson"/> .
/// </summary>
public partial class SalesPersonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesPersonProfile"/> class.
    /// </summary>
    public SalesPersonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesPerson, AdventureWorks.Repository.Domain.Models.SalesPersonModel>();

    }

}
