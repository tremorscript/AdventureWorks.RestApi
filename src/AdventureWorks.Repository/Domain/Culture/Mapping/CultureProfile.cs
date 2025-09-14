using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Culture"/> .
/// </summary>
public partial class CultureProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CultureProfile"/> class.
    /// </summary>
    public CultureProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Culture, AdventureWorks.Repository.Domain.Models.CultureModel>();

    }

}
