using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="SalesTaxRate"/> .
/// </summary>
public partial class SalesTaxRateProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesTaxRateProfile"/> class.
    /// </summary>
    public SalesTaxRateProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.SalesTaxRate, AdventureWorks.Repository.Domain.Models.SalesTaxRateModel>();

    }

}
