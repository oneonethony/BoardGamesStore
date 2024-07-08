﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.BoardGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BoardGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "D&D",
                            Price = 100.0,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Страшные сказки",
                            Price = 20.0,
                            Quantity = 7
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Ужасы Аркхэма",
                            Price = 130.0,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Дюна",
                            Price = 200.0,
                            Quantity = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
