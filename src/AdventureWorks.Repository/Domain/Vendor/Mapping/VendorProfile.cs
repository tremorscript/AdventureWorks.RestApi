using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Vendor"/> .
/// </summary>
public partial class VendorProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VendorProfile"/> class.
    /// </summary>
    public VendorProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Vendor, AdventureWorks.Repository.Domain.Models.VendorModel>();

    }

}
