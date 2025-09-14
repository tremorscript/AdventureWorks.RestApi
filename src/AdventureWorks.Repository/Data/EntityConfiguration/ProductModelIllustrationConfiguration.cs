using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ProductModelIllustrationConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ProductModelIllustration>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ProductModelIllustration> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductModelIllustration", "Production");

        // key
        builder.HasKey(t => new { t.ProductModelID, t.IllustrationID });

        // properties
        builder.Property(t => t.ProductModelID)
            .IsRequired()
            .HasColumnName("ProductModelID")
            .HasColumnType("int");

        builder.Property(t => t.IllustrationID)
            .IsRequired()
            .HasColumnName("IllustrationID")
            .HasColumnType("int");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Illustration)
            .WithMany(t => t.ProductModelIllustrations)
            .HasForeignKey(d => d.IllustrationID)
            .HasConstraintName("FK_ProductModelIllustration_Illustration_IllustrationID");

        builder.HasOne(t => t.ProductModel)
            .WithMany(t => t.ProductModelIllustrations)
            .HasForeignKey(d => d.ProductModelID)
            .HasConstraintName("FK_ProductModelIllustration_ProductModel_ProductModelID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Production";
        public const string Name = "ProductModelIllustration";
    }

    internal readonly struct Columns
    {
        public const string ProductModelID = "ProductModelID";
        public const string IllustrationID = "IllustrationID";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
