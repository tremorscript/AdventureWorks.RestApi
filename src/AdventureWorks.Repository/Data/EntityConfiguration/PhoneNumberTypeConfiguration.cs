using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class PhoneNumberTypeConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.PhoneNumberType>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.PhoneNumberType> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("PhoneNumberType", "Person");

        // key
        builder.HasKey(t => t.PhoneNumberTypeID);

        // properties
        builder.Property(t => t.PhoneNumberTypeID)
            .IsRequired()
            .HasColumnName("PhoneNumberTypeID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

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
        public const string Name = "PhoneNumberType";
    }

    internal readonly struct Columns
    {
        public const string PhoneNumberTypeID = "PhoneNumberTypeID";
        public const string Name = "Name";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
