using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ShipMethodConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ShipMethod>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ShipMethod> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ShipMethod", "Purchasing");

        // key
        builder.HasKey(t => t.ShipMethodID);

        // properties
        builder.Property(t => t.ShipMethodID)
            .IsRequired()
            .HasColumnName("ShipMethodID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.ShipBase)
            .IsRequired()
            .HasColumnName("ShipBase")
            .HasColumnType("money")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.ShipRate)
            .IsRequired()
            .HasColumnName("ShipRate")
            .HasColumnType("money")
            .HasDefaultValueSql("((0.00))");

        builder.Property(t => t.Rowguid)
            .IsRequired()
            .HasColumnName("rowguid")
            .HasColumnType("uniqueidentifier")
            .HasDefaultValueSql("(newid())");

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
        public const string Schema = "Purchasing";
        public const string Name = "ShipMethod";
    }

    internal readonly struct Columns
    {
        public const string ShipMethodID = "ShipMethodID";
        public const string Name = "Name";
        public const string ShipBase = "ShipBase";
        public const string ShipRate = "ShipRate";
        public const string Rowguid = "rowguid";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
