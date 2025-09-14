using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ProductSubcategoryConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ProductSubcategory>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ProductSubcategory> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductSubcategory", "Production");

        // key
        builder.HasKey(t => t.ProductSubcategoryID);

        // properties
        builder.Property(t => t.ProductSubcategoryID)
            .IsRequired()
            .HasColumnName("ProductSubcategoryID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.ProductCategoryID)
            .IsRequired()
            .HasColumnName("ProductCategoryID")
            .HasColumnType("int");

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
        builder.HasOne(t => t.ProductCategory)
            .WithMany(t => t.ProductSubcategories)
            .HasForeignKey(d => d.ProductCategoryID)
            .HasConstraintName("FK_ProductSubcategory_ProductCategory_ProductCategoryID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Production";
        public const string Name = "ProductSubcategory";
    }

    internal readonly struct Columns
    {
        public const string ProductSubcategoryID = "ProductSubcategoryID";
        public const string ProductCategoryID = "ProductCategoryID";
        public const string Name = "Name";
        public const string Rowguid = "rowguid";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
