using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesReason"/> .
/// </summary>
public partial class SalesReasonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesReasonProfile"/> class.
    /// </summary>
    public SalesReasonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesReason, AdventureWorks.Repository.Domain.Models.SalesReasonModel>();

    }

}
