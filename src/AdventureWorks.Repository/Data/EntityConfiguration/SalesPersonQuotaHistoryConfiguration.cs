using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class SalesPersonQuotaHistoryConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.SalesPersonQuotaHistory> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("SalesPersonQuotaHistory", "Sales");

        // key
        builder.HasKey(t => new { t.BusinessEntityID, t.QuotaDate });

        // properties
        builder.Property(t => t.BusinessEntityID)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.QuotaDate)
            .IsRequired()
            .HasColumnName("QuotaDate")
            .HasColumnType("datetime");

        builder.Property(t => t.SalesQuota)
            .IsRequired()
            .HasColumnName("SalesQuota")
            .HasColumnType("money");

        builder.Property(t => t.Rowguid)
            .IsRequired()
            .HasColumnName("rowguid")
            .HasColumnType("uniqueidentifier")
            .HasDefaultValueSql("(newid())");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.SalesPerson)
            .WithMany(t => t.SalesPersonQuotaHistories)
            .HasForeignKey(d => d.BusinessEntityID)
            .HasConstraintName("FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Sales";
        public const string Name = "SalesPersonQuotaHistory";
    }

    internal readonly struct Columns
    {
        public const string BusinessEntityID = "BusinessEntityID";
        public const string QuotaDate = "QuotaDate";
        public const string SalesQuota = "SalesQuota";
        public const string Rowguid = "rowguid";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
