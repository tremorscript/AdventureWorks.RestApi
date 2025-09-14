using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class CountryRegionConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.CountryRegion>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.CountryRegion> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("CountryRegion", "Person");

        // key
        builder.HasKey(t => t.CountryRegionCode);

        // properties
        builder.Property(t => t.CountryRegionCode)
            .IsRequired()
            .HasColumnName("CountryRegionCode")
            .HasColumnType("nvarchar(3)")
            .HasMaxLength(3);

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
        public const string Schema = "Person";
        public const string Name = "CountryRegion";
    }

    internal readonly struct Columns
    {
        public const string CountryRegionCode = "CountryRegionCode";
        public const string Name = "Name";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
