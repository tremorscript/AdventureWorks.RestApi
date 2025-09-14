using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class EmployeeDepartmentHistoryConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("EmployeeDepartmentHistory", "HumanResources");

        // key
        builder.HasKey(t => new { t.BusinessEntityID, t.DepartmentID, t.ShiftID, t.StartDate });

        // properties
        builder.Property(t => t.BusinessEntityID)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.DepartmentID)
            .IsRequired()
            .HasColumnName("DepartmentID")
            .HasColumnType("smallint");

        builder.Property(t => t.ShiftID)
            .IsRequired()
            .HasColumnName("ShiftID")
            .HasColumnType("tinyint");

        builder.Property(t => t.StartDate)
            .IsRequired()
            .HasColumnName("StartDate")
            .HasColumnType("date");

        builder.Property(t => t.EndDate)
            .HasColumnName("EndDate")
            .HasColumnType("date");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Department)
            .WithMany(t => t.EmployeeDepartmentHistories)
            .HasForeignKey(d => d.DepartmentID)
            .HasConstraintName("FK_EmployeeDepartmentHistory_Department_DepartmentID");

        builder.HasOne(t => t.Employee)
            .WithMany(t => t.EmployeeDepartmentHistories)
            .HasForeignKey(d => d.BusinessEntityID)
            .HasConstraintName("FK_EmployeeDepartmentHistory_Employee_BusinessEntityID");

        builder.HasOne(t => t.Shift)
            .WithMany(t => t.EmployeeDepartmentHistories)
            .HasForeignKey(d => d.ShiftID)
            .HasConstraintName("FK_EmployeeDepartmentHistory_Shift_ShiftID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "HumanResources";
        public const string Name = "EmployeeDepartmentHistory";
    }

    internal readonly struct Columns
    {
        public const string BusinessEntityID = "BusinessEntityID";
        public const string DepartmentID = "DepartmentID";
        public const string ShiftID = "ShiftID";
        public const string StartDate = "StartDate";
        public const string EndDate = "EndDate";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
