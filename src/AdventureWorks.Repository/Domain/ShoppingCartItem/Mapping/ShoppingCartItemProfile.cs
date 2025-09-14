using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ShoppingCartItem"/> .
/// </summary>
public partial class ShoppingCartItemProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShoppingCartItemProfile"/> class.
    /// </summary>
    public ShoppingCartItemProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ShoppingCartItem, AdventureWorks.Repository.Domain.Models.ShoppingCartItemModel>();

    }

}
