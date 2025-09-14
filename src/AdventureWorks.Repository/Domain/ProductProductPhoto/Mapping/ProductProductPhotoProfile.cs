using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductProductPhoto"/> .
/// </summary>
public partial class ProductProductPhotoProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductProductPhotoProfile"/> class.
    /// </summary>
    public ProductProductPhotoProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductProductPhoto, AdventureWorks.Repository.Domain.Models.ProductProductPhotoModel>();

    }

}
