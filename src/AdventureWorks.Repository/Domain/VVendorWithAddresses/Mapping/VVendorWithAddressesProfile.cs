using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VVendorWithAddresses"/> .
/// </summary>
public partial class VVendorWithAddressesProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VVendorWithAddressesProfile"/> class.
    /// </summary>
    public VVendorWithAddressesProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VVendorWithAddresses, AdventureWorks.Repository.Domain.Models.VVendorWithAddressesModel>();

    }

}
