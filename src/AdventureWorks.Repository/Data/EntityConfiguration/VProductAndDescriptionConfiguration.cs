using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class VProductAndDescriptionConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.VProductAndDescription>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.VProductAndDescription> builder)
    {
        #region Generated Configure
        // table
        builder.ToView("vProductAndDescription", "Production");

        // key
        builder.HasNoKey();

        // properties
        builder.Property(t => t.ProductID)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.ProductModel)
            .IsRequired()
            .HasColumnName("ProductModel")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.CultureID)
            .IsRequired()
            .HasColumnName("CultureID")
            .HasColumnType("nchar(6)")
            .HasMaxLength(6);

        builder.Property(t => t.Description)
            .IsRequired()
            .HasColumnName("Description")
            .HasColumnType("nvarchar(400)")
            .HasMaxLength(400);

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Production";
        public const string Name = "vProductAndDescription";
    }

    internal readonly struct Columns
    {
        public const string ProductID = "ProductID";
        public const string Name = "Name";
        public const string ProductModel = "ProductModel";
        public const string CultureID = "CultureID";
        public const string Description = "Description";
    }
    #endregion
}
