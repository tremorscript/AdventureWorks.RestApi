using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VEmployeeDepartmentHistory"/> .
/// </summary>
public partial class VEmployeeDepartmentHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeDepartmentHistoryProfile"/> class.
    /// </summary>
    public VEmployeeDepartmentHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryModel>();

    }

}
