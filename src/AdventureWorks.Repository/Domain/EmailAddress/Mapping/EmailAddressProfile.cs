using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="EmailAddress"/> .
/// </summary>
public partial class EmailAddressProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailAddressProfile"/> class.
    /// </summary>
    public EmailAddressProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.EmailAddress, AdventureWorks.Repository.Domain.Models.EmailAddressModel>();

    }

}
