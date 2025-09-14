using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="BusinessEntity"/> .
/// </summary>
public partial class BusinessEntityProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityProfile"/> class.
    /// </summary>
    public BusinessEntityProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.BusinessEntity, AdventureWorks.Repository.Domain.Models.BusinessEntityModel>();

    }

}
