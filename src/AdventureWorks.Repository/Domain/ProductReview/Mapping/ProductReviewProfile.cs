using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductReview"/> .
/// </summary>
public partial class ProductReviewProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductReviewProfile"/> class.
    /// </summary>
    public ProductReviewProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductReview, AdventureWorks.Repository.Domain.Models.ProductReviewModel>();

    }

}
