using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Department"/> .
/// </summary>
public partial class DepartmentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DepartmentProfile"/> class.
    /// </summary>
    public DepartmentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Department, AdventureWorks.Repository.Domain.Models.DepartmentModel>();

    }

}
