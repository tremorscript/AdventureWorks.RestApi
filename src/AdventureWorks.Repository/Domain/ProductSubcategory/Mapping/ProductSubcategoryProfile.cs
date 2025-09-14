using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductSubcategory"/> .
/// </summary>
public partial class ProductSubcategoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductSubcategoryProfile"/> class.
    /// </summary>
    public ProductSubcategoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductSubcategory, AdventureWorks.Repository.Domain.Models.ProductSubcategoryModel>();

    }

}
