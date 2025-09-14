using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ProductPhotoConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ProductPhoto>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ProductPhoto> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductPhoto", "Production");

        // key
        builder.HasKey(t => t.ProductPhotoID);

        // properties
        builder.Property(t => t.ProductPhotoID)
            .IsRequired()
            .HasColumnName("ProductPhotoID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.ThumbNailPhoto)
            .HasColumnName("ThumbNailPhoto")
            .HasColumnType("varbinary(max)");

        builder.Property(t => t.ThumbnailPhotoFileName)
            .HasColumnName("ThumbnailPhotoFileName")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.LargePhoto)
            .HasColumnName("LargePhoto")
            .HasColumnType("varbinary(max)");

        builder.Property(t => t.LargePhotoFileName)
            .HasColumnName("LargePhotoFileName")
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
        public const string Schema = "Production";
        public const string Name = "ProductPhoto";
    }

    internal readonly struct Columns
    {
        public const string ProductPhotoID = "ProductPhotoID";
        public const string ThumbNailPhoto = "ThumbNailPhoto";
        public const string ThumbnailPhotoFileName = "ThumbnailPhotoFileName";
        public const string LargePhoto = "LargePhoto";
        public const string LargePhotoFileName = "LargePhotoFileName";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
