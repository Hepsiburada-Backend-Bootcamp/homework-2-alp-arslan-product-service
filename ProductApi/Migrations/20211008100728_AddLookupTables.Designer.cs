// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProductNS.Infrastructure.Context;

namespace ProductApi.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20211008100728_AddLookupTables")]
    partial class AddLookupTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ProductNS.Domain.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_of_creation");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_brands");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("ProductNS.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_of_creation");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_categories");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("ProductNS.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("integer")
                        .HasColumnName("brand_id");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_of_creation");

                    b.Property<DateTime>("DateOfLastEdit")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_of_last_edit");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.HasIndex("BrandId")
                        .HasDatabaseName("ix_products_brand_id");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_products_category_id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("ProductNS.Domain.Models.Product", b =>
                {
                    b.HasOne("ProductNS.Domain.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .HasConstraintName("fk_products_brands_brand_id");

                    b.HasOne("ProductNS.Domain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("fk_products_categories_category_id");

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ProductNS.Domain.Models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ProductNS.Domain.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
