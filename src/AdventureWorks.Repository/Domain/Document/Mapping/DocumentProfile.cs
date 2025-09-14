using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Document"/> .
/// </summary>
public partial class DocumentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentProfile"/> class.
    /// </summary>
    public DocumentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Document, AdventureWorks.Repository.Domain.Models.DocumentModel>();

    }

}
