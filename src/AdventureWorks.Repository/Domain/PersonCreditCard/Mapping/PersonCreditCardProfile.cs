using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PersonCreditCard"/> .
/// </summary>
public partial class PersonCreditCardProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonCreditCardProfile"/> class.
    /// </summary>
    public PersonCreditCardProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.PersonCreditCard, AdventureWorks.Repository.Domain.Models.PersonCreditCardModel>();

    }

}
