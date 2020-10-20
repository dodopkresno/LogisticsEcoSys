﻿// <auto-generated />
using System;
using Inventory.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Inventory.Data.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20201020071813_Creation FirstDB")]
    partial class CreationFirstDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Inventory.Domain.Enums.MeasureType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<int>("_id")
                        .HasColumnType("integer");

                    b.Property<string>("_name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MeasureType","Inventory");
                });

            modelBuilder.Entity("Inventory.Domain.Enums.UomType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<int>("_id")
                        .HasColumnType("integer");

                    b.Property<string>("_name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UomType","Inventory");
                });

            modelBuilder.Entity("Inventory.Domain.Models.UoM", b =>
                {
                    b.Property<Guid>("UoMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<Guid>("UoMCategoryId")
                        .HasColumnType("uuid");

                    b.Property<int?>("UomTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<double>("ratio")
                        .HasColumnType("double precision");

                    b.HasKey("UoMId");

                    b.HasIndex("UoMCategoryId");

                    b.HasIndex("UomTypeId");

                    b.HasIndex("name")
                        .IsUnique();

                    b.ToTable("Uom","Inventory");
                });

            modelBuilder.Entity("Inventory.Domain.Models.UomCategory", b =>
                {
                    b.Property<Guid>("UoMCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<int?>("MeasureTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.HasKey("UoMCategoryId");

                    b.HasIndex("MeasureTypeId");

                    b.HasIndex("name")
                        .IsUnique();

                    b.ToTable("UomCategories","Inventory");
                });

            modelBuilder.Entity("Inventory.Domain.Models.UoM", b =>
                {
                    b.HasOne("Inventory.Domain.Models.UomCategory", "UomCategory")
                        .WithMany()
                        .HasForeignKey("UoMCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory.Domain.Enums.UomType", "UomType")
                        .WithMany()
                        .HasForeignKey("UomTypeId");
                });

            modelBuilder.Entity("Inventory.Domain.Models.UomCategory", b =>
                {
                    b.HasOne("Inventory.Domain.Enums.MeasureType", "MeasureType")
                        .WithMany()
                        .HasForeignKey("MeasureTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
