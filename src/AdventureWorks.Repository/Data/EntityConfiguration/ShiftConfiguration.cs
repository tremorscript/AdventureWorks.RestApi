using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ShiftConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.Shift>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.Shift> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Shift", "HumanResources");

        // key
        builder.HasKey(t => t.ShiftID);

        // properties
        builder.Property(t => t.ShiftID)
            .IsRequired()
            .HasColumnName("ShiftID")
            .HasColumnType("tinyint")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.StartTime)
            .IsRequired()
            .HasColumnName("StartTime")
            .HasColumnType("time");

        builder.Property(t => t.EndTime)
            .IsRequired()
            .HasColumnName("EndTime")
            .HasColumnType("time");

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
        public const string Schema = "HumanResources";
        public const string Name = "Shift";
    }

    internal readonly struct Columns
    {
        public const string ShiftID = "ShiftID";
        public const string Name = "Name";
        public const string StartTime = "StartTime";
        public const string EndTime = "EndTime";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
