using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ProductModelProductDescriptionCultureConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductModelProductDescriptionCulture", "Production");

        // key
        builder.HasKey(t => new { t.ProductModelID, t.ProductDescriptionID, t.CultureID });

        // properties
        builder.Property(t => t.ProductModelID)
            .IsRequired()
            .HasColumnName("ProductModelID")
            .HasColumnType("int");

        builder.Property(t => t.ProductDescriptionID)
            .IsRequired()
            .HasColumnName("ProductDescriptionID")
            .HasColumnType("int");

        builder.Property(t => t.CultureID)
            .IsRequired()
            .HasColumnName("CultureID")
            .HasColumnType("nchar(6)")
            .HasMaxLength(6);

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Culture)
            .WithMany(t => t.ProductModelProductDescriptionCultures)
            .HasForeignKey(d => d.CultureID)
            .HasConstraintName("FK_ProductModelProductDescriptionCulture_Culture_CultureID");

        builder.HasOne(t => t.ProductDescription)
            .WithMany(t => t.ProductModelProductDescriptionCultures)
            .HasForeignKey(d => d.ProductDescriptionID)
            .HasConstraintName("FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID");

        builder.HasOne(t => t.ProductModel)
            .WithMany(t => t.ProductModelProductDescriptionCultures)
            .HasForeignKey(d => d.ProductModelID)
            .HasConstraintName("FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Production";
        public const string Name = "ProductModelProductDescriptionCulture";
    }

    internal readonly struct Columns
    {
        public const string ProductModelID = "ProductModelID";
        public const string ProductDescriptionID = "ProductDescriptionID";
        public const string CultureID = "CultureID";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
