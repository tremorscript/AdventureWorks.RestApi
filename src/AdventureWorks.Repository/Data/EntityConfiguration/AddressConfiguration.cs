using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class AddressConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.Address>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.Address> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Address", "Person");

        // key
        builder.HasKey(t => t.AddressID);

        // properties
        builder.Property(t => t.AddressID)
            .IsRequired()
            .HasColumnName("AddressID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.AddressLine1)
            .IsRequired()
            .HasColumnName("AddressLine1")
            .HasColumnType("nvarchar(60)")
            .HasMaxLength(60);

        builder.Property(t => t.AddressLine2)
            .HasColumnName("AddressLine2")
            .HasColumnType("nvarchar(60)")
            .HasMaxLength(60);

        builder.Property(t => t.City)
            .IsRequired()
            .HasColumnName("City")
            .HasColumnType("nvarchar(30)")
            .HasMaxLength(30);

        builder.Property(t => t.StateProvinceID)
            .IsRequired()
            .HasColumnName("StateProvinceID")
            .HasColumnType("int");

        builder.Property(t => t.PostalCode)
            .IsRequired()
            .HasColumnName("PostalCode")
            .HasColumnType("nvarchar(15)")
            .HasMaxLength(15);

        builder.Property(t => t.SpatialLocation)
            .HasColumnName("SpatialLocation")
            .HasColumnType("geography");

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
        builder.HasOne(t => t.StateProvince)
            .WithMany(t => t.Addresses)
            .HasForeignKey(d => d.StateProvinceID)
            .HasConstraintName("FK_Address_StateProvince_StateProvinceID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Person";
        public const string Name = "Address";
    }

    internal readonly struct Columns
    {
        public const string AddressID = "AddressID";
        public const string AddressLine1 = "AddressLine1";
        public const string AddressLine2 = "AddressLine2";
        public const string City = "City";
        public const string StateProvinceID = "StateProvinceID";
        public const string PostalCode = "PostalCode";
        public const string SpatialLocation = "SpatialLocation";
        public const string Rowguid = "rowguid";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
