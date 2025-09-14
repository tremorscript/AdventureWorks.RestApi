using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class PasswordConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.Password>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.Password> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Password", "Person");

        // key
        builder.HasKey(t => t.BusinessEntityID);

        // properties
        builder.Property(t => t.BusinessEntityID)
            .IsRequired()
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.PasswordHash)
            .IsRequired()
            .HasColumnName("PasswordHash")
            .HasColumnType("varchar(128)")
            .HasMaxLength(128);

        builder.Property(t => t.PasswordSalt)
            .IsRequired()
            .HasColumnName("PasswordSalt")
            .HasColumnType("varchar(10)")
            .HasMaxLength(10);

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
        builder.HasOne(t => t.Person)
            .WithOne(t => t.Password)
            .HasForeignKey<AdventureWorks.Repository.Data.Entities.Password>(d => d.BusinessEntityID)
            .HasConstraintName("FK_Password_Person_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Person";
        public const string Name = "Password";
    }

    internal readonly struct Columns
    {
        public const string BusinessEntityID = "BusinessEntityID";
        public const string PasswordHash = "PasswordHash";
        public const string PasswordSalt = "PasswordSalt";
        public const string Rowguid = "rowguid";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
