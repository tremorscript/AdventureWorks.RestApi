using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Product"/> .
/// </summary>
public partial class ProductProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductProfile"/> class.
    /// </summary>
    public ProductProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Product, AdventureWorks.Repository.Domain.Models.ProductModel>();

    }

}
