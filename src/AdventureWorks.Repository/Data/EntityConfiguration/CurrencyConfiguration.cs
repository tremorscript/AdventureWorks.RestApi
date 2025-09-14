using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class CurrencyConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.Currency>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.Currency> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Currency", "Sales");

        // key
        builder.HasKey(t => t.CurrencyCode);

        // properties
        builder.Property(t => t.CurrencyCode)
            .IsRequired()
            .HasColumnName("CurrencyCode")
            .HasColumnType("nchar(3)")
            .HasMaxLength(3);

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

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
        public const string Name = "Currency";
    }

    internal readonly struct Columns
    {
        public const string CurrencyCode = "CurrencyCode";
        public const string Name = "Name";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
