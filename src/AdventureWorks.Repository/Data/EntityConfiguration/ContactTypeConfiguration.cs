using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ContactTypeConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ContactType>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ContactType> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ContactType", "Person");

        // key
        builder.HasKey(t => t.ContactTypeID);

        // properties
        builder.Property(t => t.ContactTypeID)
            .IsRequired()
            .HasColumnName("ContactTypeID")
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
        public const string Name = "ContactType";
    }

    internal readonly struct Columns
    {
        public const string ContactTypeID = "ContactTypeID";
        public const string Name = "Name";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
