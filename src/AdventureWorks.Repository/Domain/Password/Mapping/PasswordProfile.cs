using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Password"/> .
/// </summary>
public partial class PasswordProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordProfile"/> class.
    /// </summary>
    public PasswordProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Password, AdventureWorks.Repository.Domain.Models.PasswordModel>();

    }

}
