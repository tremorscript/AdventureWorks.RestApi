using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PhoneNumberType"/> .
/// </summary>
public partial class PhoneNumberTypeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneNumberTypeProfile"/> class.
    /// </summary>
    public PhoneNumberTypeProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.PhoneNumberType, AdventureWorks.Repository.Domain.Models.PhoneNumberTypeModel>();

    }

}
