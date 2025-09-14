using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductModel"/> .
/// </summary>
public partial class ProductModelProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelProfile"/> class.
    /// </summary>
    public ProductModelProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModel, AdventureWorks.Repository.Domain.Models.ProductModelModel>();

    }

}
