using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Address"/> .
/// </summary>
public partial class AddressProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddressProfile"/> class.
    /// </summary>
    public AddressProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Address, AdventureWorks.Repository.Domain.Models.AddressModel>();

    }

}
