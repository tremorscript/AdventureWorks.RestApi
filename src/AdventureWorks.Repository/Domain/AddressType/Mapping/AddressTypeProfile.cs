using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="AddressType"/> .
/// </summary>
public partial class AddressTypeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressTypeProfile"/> class.
    /// </summary>
    public AddressTypeProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.AddressType, AdventureWorks.Repository.Domain.Models.AddressTypeModel>();

    }

}
