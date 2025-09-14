using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductDocument"/> .
/// </summary>
public partial class ProductDocumentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDocumentProfile"/> class.
    /// </summary>
    public ProductDocumentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductDocument, AdventureWorks.Repository.Domain.Models.ProductDocumentModel>();

    }

}
