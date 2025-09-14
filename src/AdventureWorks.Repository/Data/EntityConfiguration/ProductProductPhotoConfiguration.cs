using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ProductProductPhotoConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ProductProductPhoto>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ProductProductPhoto> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductProductPhoto", "Production");

        // key
        builder.HasKey(t => new { t.ProductID, t.ProductPhotoID });

        // properties
        builder.Property(t => t.ProductID)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.ProductPhotoID)
            .IsRequired()
            .HasColumnName("ProductPhotoID")
            .HasColumnType("int");

        builder.Property(t => t.Primary)
            .IsRequired()
            .HasColumnName("Primary")
            .HasColumnType("bit")
            .HasDefaultValue(false);

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Product)
            .WithMany(t => t.ProductProductPhotos)
            .HasForeignKey(d => d.ProductID)
            .HasConstraintName("FK_ProductProductPhoto_Product_ProductID");

        builder.HasOne(t => t.ProductPhoto)
            .WithMany(t => t.ProductProductPhotos)
            .HasForeignKey(d => d.ProductPhotoID)
            .HasConstraintName("FK_ProductProductPhoto_ProductPhoto_ProductPhotoID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Production";
        public const string Name = "ProductProductPhoto";
    }

    internal readonly struct Columns
    {
        public const string ProductID = "ProductID";
        public const string ProductPhotoID = "ProductPhotoID";
        public const string Primary = "Primary";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
