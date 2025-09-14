using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class StoreConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.Store>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.Store> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Store", "Sales");

        // key
        builder.HasKey(t => t.BusinessEntityID);

        // properties
        builder.Property(t => t.BusinessEntityID)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.SalesPersonID)
            .HasColumnName("SalesPersonID")
            .HasColumnType("int");

        builder.Property(t => t.Demographics)
            .HasColumnName("Demographics")
            .HasColumnType("xml");

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
        builder.HasOne(t => t.BusinessEntity)
            .WithOne(t => t.Store)
            .HasForeignKey<AdventureWorks.Repository.Data.Entities.Store>(d => d.BusinessEntityID)
            .HasConstraintName("FK_Store_BusinessEntity_BusinessEntityID");

        builder.HasOne(t => t.SalesPerson)
            .WithMany(t => t.Stores)
            .HasForeignKey(d => d.SalesPersonID)
            .HasConstraintName("FK_Store_SalesPerson_SalesPersonID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Sales";
        public const string Name = "Store";
    }

    internal readonly struct Columns
    {
        public const string BusinessEntityID = "BusinessEntityID";
        public const string Name = "Name";
        public const string SalesPersonID = "SalesPersonID";
        public const string Demographics = "Demographics";
        public const string Rowguid = "rowguid";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
