using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="TransactionHistoryArchive"/> .
/// </summary>
public partial class TransactionHistoryArchiveProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryArchiveProfile"/> class.
    /// </summary>
    public TransactionHistoryArchiveProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.TransactionHistoryArchive, AdventureWorks.Repository.Domain.Models.TransactionHistoryArchiveModel>();

    }

}
