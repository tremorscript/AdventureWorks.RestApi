using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductListPriceHistory"/> .
/// </summary>
public partial class ProductListPriceHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductListPriceHistoryProfile"/> class.
    /// </summary>
    public ProductListPriceHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductListPriceHistory, AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryModel>();

    }

}
