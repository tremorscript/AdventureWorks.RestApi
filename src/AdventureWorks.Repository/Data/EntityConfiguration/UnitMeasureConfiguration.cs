using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class UnitMeasureConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.UnitMeasure>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.UnitMeasure> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("UnitMeasure", "Production");

        // key
        builder.HasKey(t => t.UnitMeasureCode);

        // properties
        builder.Property(t => t.UnitMeasureCode)
            .IsRequired()
            .HasColumnName("UnitMeasureCode")
            .HasColumnType("nchar(3)")
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
        public const string Schema = "Production";
        public const string Name = "UnitMeasure";
    }

    internal readonly struct Columns
    {
        public const string UnitMeasureCode = "UnitMeasureCode";
        public const string Name = "Name";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
