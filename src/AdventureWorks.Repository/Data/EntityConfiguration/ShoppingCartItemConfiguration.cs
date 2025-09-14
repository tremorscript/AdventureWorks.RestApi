using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

internal partial class ShoppingCartItemConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ShoppingCartItem>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ShoppingCartItem> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ShoppingCartItem", "Sales");

        // key
        builder.HasKey(t => t.ShoppingCartItemID);

        // properties
        builder.Property(t => t.ShoppingCartItemID)
            .IsRequired()
            .HasColumnName("ShoppingCartItemID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.ShoppingCartID)
            .IsRequired()
            .HasColumnName("ShoppingCartID")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Quantity)
            .IsRequired()
            .HasColumnName("Quantity")
            .HasColumnType("int")
            .HasDefaultValue(1);

        builder.Property(t => t.ProductID)
            .IsRequired()
            .HasColumnName("ProductID")
            .HasColumnType("int");

        builder.Property(t => t.DateCreated)
            .IsRequired()
            .HasColumnName("DateCreated")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Product)
            .WithMany(t => t.ShoppingCartItems)
            .HasForeignKey(d => d.ProductID)
            .HasConstraintName("FK_ShoppingCartItem_Product_ProductID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        public const string Schema = "Sales";
        public const string Name = "ShoppingCartItem";
    }

    internal readonly struct Columns
    {
        public const string ShoppingCartItemID = "ShoppingCartItemID";
        public const string ShoppingCartID = "ShoppingCartID";
        public const string Quantity = "Quantity";
        public const string ProductID = "ProductID";
        public const string DateCreated = "DateCreated";
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
