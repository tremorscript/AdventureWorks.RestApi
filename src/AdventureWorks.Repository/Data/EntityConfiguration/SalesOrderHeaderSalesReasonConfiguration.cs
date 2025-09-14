using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class SalesOrderHeaderSalesReasonConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.SalesOrderHeaderSalesReason> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("SalesOrderHeaderSalesReason", "Sales");

        // key
        builder.HasKey(t => new { t.SalesOrderID, t.SalesReasonID });

        // properties
        builder.Property(t => t.SalesOrderID)
            .IsRequired()
            .HasColumnName("SalesOrderID")
            .HasColumnType("int");

        builder.Property(t => t.SalesReasonID)
            .IsRequired()
            .HasColumnName("SalesReasonID")
            .HasColumnType("int");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.SalesOrderHeader)
            .WithMany(t => t.SalesOrderHeaderSalesReasons)
            .HasForeignKey(d => d.SalesOrderID)
            .HasConstraintName("FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID");

        builder.HasOne(t => t.SalesReason)
            .WithMany(t => t.SalesOrderHeaderSalesReasons)
            .HasForeignKey(d => d.SalesReasonID)
            .HasConstraintName("FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Sales";
        public const string Name = "SalesOrderHeaderSalesReason";
    }

    internal readonly struct Columns
    {
        public const string SalesOrderID = "SalesOrderID";
        public const string SalesReasonID = "SalesReasonID";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
