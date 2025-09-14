using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="CreditCard"/> .
/// </summary>
public partial class CreditCardProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreditCardProfile"/> class.
    /// </summary>
    public CreditCardProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.CreditCard, AdventureWorks.Repository.Domain.Models.CreditCardModel>();

    }

}
