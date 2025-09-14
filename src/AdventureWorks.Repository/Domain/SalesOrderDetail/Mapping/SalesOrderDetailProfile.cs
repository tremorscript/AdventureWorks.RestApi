using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesOrderDetail"/> .
/// </summary>
public partial class SalesOrderDetailProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesOrderDetailProfile"/> class.
    /// </summary>
    public SalesOrderDetailProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesOrderDetail, AdventureWorks.Repository.Domain.Models.SalesOrderDetailModel>();

    }

}
