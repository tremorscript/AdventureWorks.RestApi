using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PersonPhone"/> .
/// </summary>
public partial class PersonPhoneProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonPhoneProfile"/> class.
    /// </summary>
    public PersonPhoneProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.PersonPhone, AdventureWorks.Repository.Domain.Models.PersonPhoneModel>();

    }

}
