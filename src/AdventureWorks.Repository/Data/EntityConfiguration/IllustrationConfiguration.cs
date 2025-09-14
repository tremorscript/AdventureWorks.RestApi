using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class IllustrationConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.Illustration>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.Illustration> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Illustration", "Production");

        // key
        builder.HasKey(t => t.IllustrationID);

        // properties
        builder.Property(t => t.IllustrationID)
            .IsRequired()
            .HasColumnName("IllustrationID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Diagram)
            .HasColumnName("Diagram")
            .HasColumnType("xml");

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
        public const string Name = "Illustration";
    }

    internal readonly struct Columns
    {
        public const string IllustrationID = "IllustrationID";
        public const string Diagram = "Diagram";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
