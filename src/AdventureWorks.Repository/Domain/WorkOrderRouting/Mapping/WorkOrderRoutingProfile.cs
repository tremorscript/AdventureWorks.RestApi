using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="WorkOrderRouting"/> .
/// </summary>
public partial class WorkOrderRoutingProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderRoutingProfile"/> class.
    /// </summary>
    public WorkOrderRoutingProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.WorkOrderRouting, AdventureWorks.Repository.Domain.Models.WorkOrderRoutingModel>();

    }

}
