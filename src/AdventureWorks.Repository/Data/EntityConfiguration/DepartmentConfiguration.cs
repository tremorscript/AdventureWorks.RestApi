using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class DepartmentConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.Department>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.Department> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Department", "HumanResources");

        // key
        builder.HasKey(t => t.DepartmentID);

        // properties
        builder.Property(t => t.DepartmentID)
            .IsRequired()
            .HasColumnName("DepartmentID")
            .HasColumnType("smallint")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.GroupName)
            .IsRequired()
            .HasColumnName("GroupName")
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
        public const string Schema = "HumanResources";
        public const string Name = "Department";
    }

    internal readonly struct Columns
    {
        public const string DepartmentID = "DepartmentID";
        public const string Name = "Name";
        public const string GroupName = "GroupName";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
