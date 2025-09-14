using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductInventory"/> .
/// </summary>
public partial class ProductInventoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductInventoryProfile"/> class.
    /// </summary>
    public ProductInventoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductInventory, AdventureWorks.Repository.Domain.Models.ProductInventoryModel>();

    }

}
