﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.Models;

#nullable disable

namespace Todo_API.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20230412210948_AddDescriptionAndDateTimeToTheModel")]
    partial class AddDescriptionAndDateTimeToTheModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Todo_API.Entities.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Task")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TaskTimestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsComplete = false,
                            Task = "Go to the gym"
                        },
                        new
                        {
                            Id = 2L,
                            IsComplete = false,
                            Task = "Learn something new"
                        },
                        new
                        {
                            Id = 3L,
                            IsComplete = false,
                            Task = "Clean up the house"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}