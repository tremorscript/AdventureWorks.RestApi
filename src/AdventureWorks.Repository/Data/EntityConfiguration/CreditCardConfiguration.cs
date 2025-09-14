using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class CreditCardConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.CreditCard>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.CreditCard> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("CreditCard", "Sales");

        // key
        builder.HasKey(t => t.CreditCardID);

        // properties
        builder.Property(t => t.CreditCardID)
            .IsRequired()
            .HasColumnName("CreditCardID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.CardType)
            .IsRequired()
            .HasColumnName("CardType")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.CardNumber)
            .IsRequired()
            .HasColumnName("CardNumber")
            .HasColumnType("nvarchar(25)")
            .HasMaxLength(25);

        builder.Property(t => t.ExpMonth)
            .IsRequired()
            .HasColumnName("ExpMonth")
            .HasColumnType("tinyint");

        builder.Property(t => t.ExpYear)
            .IsRequired()
            .HasColumnName("ExpYear")
            .HasColumnType("smallint");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Sales";
        public const string Name = "CreditCard";
    }

    internal readonly struct Columns
    {
        public const string CreditCardID = "CreditCardID";
        public const string CardType = "CardType";
        public const string CardNumber = "CardNumber";
        public const string ExpMonth = "ExpMonth";
        public const string ExpYear = "ExpYear";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
