﻿// <auto-generated />
using EasyRecipesWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyRecipesWebApi.Migrations
{
    [DbContext(typeof(EasyRecipesContext))]
    [Migration("20190702184011_ModelBuilderSeedTest")]
    partial class ModelBuilderSeedTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyRecipesWebApi.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount");

                    b.Property<int>("MeasurementUnitId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MeasurementUnitId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("EasyRecipesWebApi.Models.MeasurementUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Unit")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MeasurementUnit");

                    b.HasData(
                        new { Id = 1, Unit = "Gram" },
                        new { Id = 2, Unit = "Millilitre" },
                        new { Id = 3, Unit = "Piece" },
                        new { Id = 4, Unit = "Spoon" },
                        new { Id = 5, Unit = "Tablespoon" },
                        new { Id = 6, Unit = "Pinch" },
                        new { Id = 7, Unit = "Glass" },
                        new { Id = 8, Unit = "None" }
                    );
                });

            modelBuilder.Entity("EasyRecipesWebApi.Models.Ingredient", b =>
                {
                    b.HasOne("EasyRecipesWebApi.Models.MeasurementUnit", "MeasurementUnit")
                        .WithMany("Ingredients")
                        .HasForeignKey("MeasurementUnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
