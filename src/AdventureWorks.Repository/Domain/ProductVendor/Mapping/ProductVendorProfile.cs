using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductVendor"/> .
/// </summary>
public partial class ProductVendorProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductVendorProfile"/> class.
    /// </summary>
    public ProductVendorProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductVendor, AdventureWorks.Repository.Domain.Models.ProductVendorModel>();

    }

}
