using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ProductDocumentConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ProductDocument>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ProductDocument> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ProductDocument", "Production");

        // key
        builder.HasKey(t => t.ProductID);

        // properties
        builder.Property(t => t.ProductID)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Product)
            .WithMany(t => t.ProductDocuments)
            .HasForeignKey(d => d.ProductID)
            .HasConstraintName("FK_ProductDocument_Product_ProductID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Production";
        public const string Name = "ProductDocument";
    }

    internal readonly struct Columns
    {
        public const string ProductID = "ProductID";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
