using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SpecialOfferProduct"/> .
/// </summary>
public partial class SpecialOfferProductProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOfferProductProfile"/> class.
    /// </summary>
    public SpecialOfferProductProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SpecialOfferProduct, AdventureWorks.Repository.Domain.Models.SpecialOfferProductModel>();

    }

}
