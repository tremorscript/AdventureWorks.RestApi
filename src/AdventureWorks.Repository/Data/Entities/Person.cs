using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

internal partial class Person
    : EntityBase
{
    public Person()
    {
        #region Generated Constructor
        BusinessEntityContacts = new HashSet<BusinessEntityContact>();
        Customers = new HashSet<Customer>();
        EmailAddresses = new HashSet<EmailAddress>();
        PersonCreditCards = new HashSet<PersonCreditCard>();
        PersonPhones = new HashSet<PersonPhone>();
        #endregion
    }

    #region Generated Properties
    public int BusinessEntityID { get; set; }

    public string PersonType { get; set; } = null!;

    public bool NameStyle { get; set; }

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public int EmailPromotion { get; set; }

    public string? AdditionalContactInfo { get; set; }

    public string? Demographics { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    public virtual BusinessEntity BusinessEntity { get; set; } = null!;

    public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

    public virtual ICollection<Customer> Customers { get; set; }

    public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Password Password { get; set; } = null!;

    public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

    public virtual ICollection<PersonPhone> PersonPhones { get; set; }

    #endregion

}
