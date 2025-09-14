using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class AddressTypeConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.AddressType>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.AddressType> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("AddressType", "Person");

        // key
        builder.HasKey(t => t.AddressTypeID);

        // properties
        builder.Property(t => t.AddressTypeID)
            .IsRequired()
            .HasColumnName("AddressTypeID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

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
        public const string Schema = "Person";
        public const string Name = "AddressType";
    }

    internal readonly struct Columns
    {
        public const string AddressTypeID = "AddressTypeID";
        public const string Name = "Name";
        public const string Rowguid = "rowguid";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
