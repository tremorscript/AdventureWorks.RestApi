using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="WorkOrder"/> .
/// </summary>
public partial class WorkOrderProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrderProfile"/> class.
    /// </summary>
    public WorkOrderProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.WorkOrder, AdventureWorks.Repository.Domain.Models.WorkOrderModel>();

    }

}
