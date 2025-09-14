using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VEmployeeDepartment"/> .
/// </summary>
public partial class VEmployeeDepartmentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeDepartmentProfile"/> class.
    /// </summary>
    public VEmployeeDepartmentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployeeDepartment, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentModel>();

    }

}
