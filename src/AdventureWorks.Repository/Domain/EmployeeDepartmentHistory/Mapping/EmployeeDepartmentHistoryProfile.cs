using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="EmployeeDepartmentHistory"/> .
/// </summary>
public partial class EmployeeDepartmentHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeDepartmentHistoryProfile"/> class.
    /// </summary>
    public EmployeeDepartmentHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory, AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryModel>();

    }

}
