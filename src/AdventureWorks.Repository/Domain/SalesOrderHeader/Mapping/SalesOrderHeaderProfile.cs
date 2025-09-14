using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesOrderHeader"/> .
/// </summary>
public partial class SalesOrderHeaderProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderHeaderProfile"/> class.
    /// </summary>
    public SalesOrderHeaderProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderHeader, AdventureWorks.Repository.Domain.Models.SalesOrderHeaderModel>();

    }

}
