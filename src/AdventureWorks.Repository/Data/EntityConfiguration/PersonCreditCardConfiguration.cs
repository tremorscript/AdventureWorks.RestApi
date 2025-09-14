using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class PersonCreditCardConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.PersonCreditCard>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.PersonCreditCard> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("PersonCreditCard", "Sales");

        // key
        builder.HasKey(t => new { t.BusinessEntityID, t.CreditCardID });

        // properties
        builder.Property(t => t.BusinessEntityID)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.CreditCardID)
            .IsRequired()
            .HasColumnName("CreditCardID")
            .HasColumnType("int");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.CreditCard)
            .WithMany(t => t.PersonCreditCards)
            .HasForeignKey(d => d.CreditCardID)
            .HasConstraintName("FK_PersonCreditCard_CreditCard_CreditCardID");

        builder.HasOne(t => t.Person)
            .WithMany(t => t.PersonCreditCards)
            .HasForeignKey(d => d.BusinessEntityID)
            .HasConstraintName("FK_PersonCreditCard_Person_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Sales";
        public const string Name = "PersonCreditCard";
    }

    internal readonly struct Columns
    {
        public const string BusinessEntityID = "BusinessEntityID";
        public const string CreditCardID = "CreditCardID";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
