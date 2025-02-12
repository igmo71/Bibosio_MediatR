﻿// <auto-generated />
using System;
using Bibosio.WebApp.Modules.TodosModule.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bibosio.WebApp.Modules.TodosModule.Infrastructure.Migrations
{
    [DbContext(typeof(TodosDbContext))]
    [Migration("20240819150434_Create_Todos")]
    partial class Create_Todos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("todo")
                .HasAnnotation("ProductVersion", "9.0.0-preview.7.24405.3");

            modelBuilder.Entity("Bibosio.WebApp.Modules.TodosModule.TodosDomain.Todo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(264)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EditDateTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Todos", "todo");
                });
#pragma warning restore 612, 618
        }
    }
}
