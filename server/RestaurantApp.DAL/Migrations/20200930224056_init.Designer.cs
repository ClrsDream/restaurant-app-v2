﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantApp.DAL;

namespace RestaurantApp.DAL.Migrations
{
    [DbContext(typeof(RestaurantAppContext))]
    [Migration("20200930224056_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantApp.DAL.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedOn = new DateTime(2020, 9, 30, 18, 40, 56, 267, DateTimeKind.Local).AddTicks(6730),
                            Email = "weijie0192@gmail.com",
                            Name = "Manager",
                            Password = "$2a$11$EUS5tspPIQF8P0W32W7FBOS/H3tlPahiTo4AU9tIfP3.2pTqvZmRi"
                        });
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.Card", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EncryptedCardInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HolderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LastFourDigit")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AccountID");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tax")
                        .HasColumnType("int");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuEntry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.ToTable("MenuEntries");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("CanAddSides")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuEntryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OptionPriceMultiplier")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MenuEntryID");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuItemMenuOptionGroup", b =>
                {
                    b.Property<int>("MenuItemID")
                        .HasColumnType("int");

                    b.Property<int>("MenuOptionGroupID")
                        .HasColumnType("int");

                    b.HasKey("MenuItemID", "MenuOptionGroupID");

                    b.HasIndex("MenuOptionGroupID");

                    b.ToTable("MenuItemMenuOptionGroups");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuOptionGroup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MenuOptionGroups");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuOptionItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<int?>("MenuOptionGroupID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("MenuOptionGroupID");

                    b.ToTable("MenuOptionItems");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EncryptedCardInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Tip")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("AccountID");

                    b.HasIndex("MenuID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.OrderedItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EncryptedCardInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<double>("Tip")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("AccountID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderedItems");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.OrderedItemMenuOptionItem", b =>
                {
                    b.Property<int>("MenuOptionItemID")
                        .HasColumnType("int");

                    b.Property<int>("OrderedItemID")
                        .HasColumnType("int");

                    b.HasKey("MenuOptionItemID", "OrderedItemID");

                    b.HasIndex("OrderedItemID");

                    b.ToTable("OrderedItemMenuOptionItems");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.Card", b =>
                {
                    b.HasOne("RestaurantApp.DAL.Models.Account", "Account")
                        .WithMany("Cards")
                        .HasForeignKey("AccountID");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuEntry", b =>
                {
                    b.HasOne("RestaurantApp.DAL.Models.Menu", "Menu")
                        .WithMany("MenuEntries")
                        .HasForeignKey("MenuID");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuItem", b =>
                {
                    b.HasOne("RestaurantApp.DAL.Models.MenuEntry", "MenuEntry")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuEntryID");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuItemMenuOptionGroup", b =>
                {
                    b.HasOne("RestaurantApp.DAL.Models.MenuItem", "MenuItem")
                        .WithMany("MenuItemMenuOptionGroups")
                        .HasForeignKey("MenuItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantApp.DAL.Models.MenuOptionGroup", "MenuOptionGroup")
                        .WithMany("MenuItemMenuOptionGroups")
                        .HasForeignKey("MenuOptionGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.MenuOptionItem", b =>
                {
                    b.HasOne("RestaurantApp.DAL.Models.Menu", "Menu")
                        .WithMany("SideItems")
                        .HasForeignKey("MenuID");

                    b.HasOne("RestaurantApp.DAL.Models.MenuOptionGroup", "MenuOptionGroup")
                        .WithMany("MenuOptionItems")
                        .HasForeignKey("MenuOptionGroupID");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.Order", b =>
                {
                    b.HasOne("RestaurantApp.DAL.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("RestaurantApp.DAL.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuID");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.OrderedItem", b =>
                {
                    b.HasOne("RestaurantApp.DAL.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("RestaurantApp.DAL.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuID");

                    b.HasOne("RestaurantApp.DAL.Models.Order", null)
                        .WithMany("OrderedItems")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("RestaurantApp.DAL.Models.OrderedItemMenuOptionItem", b =>
                {
                    b.HasOne("RestaurantApp.DAL.Models.MenuOptionItem", "MenuOptionItem")
                        .WithMany("OrderedItemMenuOptionItems")
                        .HasForeignKey("MenuOptionItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantApp.DAL.Models.OrderedItem", "OrderedItem")
                        .WithMany("OrderedItemMenuOptionItems")
                        .HasForeignKey("OrderedItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
