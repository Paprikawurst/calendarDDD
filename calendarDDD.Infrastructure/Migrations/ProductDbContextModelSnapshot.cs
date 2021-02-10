﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using calendarDDD.Infrastructure;

namespace calendarDDD.Infrastructure.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("calendarDDD.Domain.AggregateModels.ProductAggregate.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ProductEntity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cbb4e938-3be3-41cf-a52b-efbf30b45b01"),
                            Description = "This is a best gaming laptop",
                            Name = "Laptop",
                            Price = 20.02,
                            Quantity = 10
                        },
                        new
                        {
                            Id = new Guid("4f050d87-4b07-4862-aee3-a01c1c788897"),
                            Description = "This is a Office Application",
                            Name = "Microsoft Office",
                            Price = 20.989999999999998,
                            Quantity = 50
                        },
                        new
                        {
                            Id = new Guid("464d6ee0-a4c1-4175-92a4-aa4e7cdf77b6"),
                            Description = "The mouse that works on all surface",
                            Name = "Lazer Mouse",
                            Price = 12.02,
                            Quantity = 20
                        },
                        new
                        {
                            Id = new Guid("dfb152ee-8107-4bc6-8ff7-1a6746dc8f3d"),
                            Description = "To store 256GB of data",
                            Name = "USB Storage",
                            Price = 5.0,
                            Quantity = 20
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
