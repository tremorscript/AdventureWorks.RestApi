using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ContactType"/> .
/// </summary>
public partial class ContactTypeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactTypeProfile"/> class.
    /// </summary>
    public ContactTypeProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ContactType, AdventureWorks.Repository.Domain.Models.ContactTypeModel>();

    }

}
