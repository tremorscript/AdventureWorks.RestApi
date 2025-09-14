using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="TransactionHistory"/> .
/// </summary>
public partial class TransactionHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistoryProfile"/> class.
    /// </summary>
    public TransactionHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.TransactionHistory, AdventureWorks.Repository.Domain.Models.TransactionHistoryModel>();

    }

}
