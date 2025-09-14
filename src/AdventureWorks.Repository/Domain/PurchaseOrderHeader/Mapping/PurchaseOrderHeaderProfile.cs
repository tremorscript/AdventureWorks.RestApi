using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PurchaseOrderHeader"/> .
/// </summary>
public partial class PurchaseOrderHeaderProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderHeaderProfile"/> class.
    /// </summary>
    public PurchaseOrderHeaderProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.PurchaseOrderHeader, AdventureWorks.Repository.Domain.Models.PurchaseOrderHeaderModel>();

    }

}
