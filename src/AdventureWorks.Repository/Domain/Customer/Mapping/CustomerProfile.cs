using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Customer"/> .
/// </summary>
public partial class CustomerProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerProfile"/> class.
    /// </summary>
    public CustomerProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Customer, AdventureWorks.Repository.Domain.Models.CustomerModel>();

    }

}
