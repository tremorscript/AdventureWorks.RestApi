using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VProductModelCatalogDescription"/> .
/// </summary>
public partial class VProductModelCatalogDescriptionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelCatalogDescriptionProfile"/> class.
    /// </summary>
    public VProductModelCatalogDescriptionProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription, AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionModel>();

    }

}
