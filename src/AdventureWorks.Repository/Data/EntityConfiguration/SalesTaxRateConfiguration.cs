using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class SalesTaxRateConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.SalesTaxRate>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.SalesTaxRate> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("SalesTaxRate", "Sales");

        // key
        builder.HasKey(t => t.SalesTaxRateID);

        // properties
        builder.Property(t => t.SalesTaxRateID)
            .IsRequired()
            .HasColumnName("SalesTaxRateID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.StateProvinceID)
            .IsRequired()
            .HasColumnName("StateProvinceID")
            .HasColumnType("int");

        builder.Property(t => t.TaxType)
            .IsRequired()
            .HasColumnName("TaxType")
            .HasColumnType("tinyint");

        builder.Property(t => t.TaxRate)
            .IsRequired()
            .HasColumnName("TaxRate")
            .HasColumnType("smallmoney")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

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
        builder.HasOne(t => t.StateProvince)
            .WithMany(t => t.SalesTaxRates)
            .HasForeignKey(d => d.StateProvinceID)
            .HasConstraintName("FK_SalesTaxRate_StateProvince_StateProvinceID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Sales";
        public const string Name = "SalesTaxRate";
    }

    internal readonly struct Columns
    {
        public const string SalesTaxRateID = "SalesTaxRateID";
        public const string StateProvinceID = "StateProvinceID";
        public const string TaxType = "TaxType";
        public const string TaxRate = "TaxRate";
        public const string Name = "Name";
        public const string Rowguid = "rowguid";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
