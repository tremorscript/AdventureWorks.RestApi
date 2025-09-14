using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class CultureConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.Culture>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.Culture> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Culture", "Production");

        // key
        builder.HasKey(t => t.CultureID);

        // properties
        builder.Property(t => t.CultureID)
            .IsRequired()
            .HasColumnName("CultureID")
            .HasColumnType("nchar(6)")
            .HasMaxLength(6);

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
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
        public const string Name = "Culture";
    }

    internal readonly struct Columns
    {
        public const string CultureID = "CultureID";
        public const string Name = "Name";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
