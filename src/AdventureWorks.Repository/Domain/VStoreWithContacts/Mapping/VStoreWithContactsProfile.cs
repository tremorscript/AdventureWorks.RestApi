using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStoreWithContacts"/> .
/// </summary>
public partial class VStoreWithContactsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithContactsProfile"/> class.
    /// </summary>
    public VStoreWithContactsProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithContacts, AdventureWorks.Repository.Domain.Models.VStoreWithContactsModel>();

    }

}
