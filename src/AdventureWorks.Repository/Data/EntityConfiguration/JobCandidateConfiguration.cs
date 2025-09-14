using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class JobCandidateConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.JobCandidate>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.JobCandidate> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("JobCandidate", "HumanResources");

        // key
        builder.HasKey(t => t.JobCandidateID);

        // properties
        builder.Property(t => t.JobCandidateID)
            .IsRequired()
            .HasColumnName("JobCandidateID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.BusinessEntityID)
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.Resume)
            .HasColumnName("Resume")
            .HasColumnType("xml");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Employee)
            .WithMany(t => t.JobCandidates)
            .HasForeignKey(d => d.BusinessEntityID)
            .HasConstraintName("FK_JobCandidate_Employee_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "HumanResources";
        public const string Name = "JobCandidate";
    }

    internal readonly struct Columns
    {
        public const string JobCandidateID = "JobCandidateID";
        public const string BusinessEntityID = "BusinessEntityID";
        public const string Resume = "Resume";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
