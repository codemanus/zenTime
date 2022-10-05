﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zenTime.Server.Data;

#nullable disable

namespace zenTime.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221004230421_UpdatedModels")]
    partial class UpdatedModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("zenTime.Shared.HourModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("HoursAmount")
                        .HasColumnType("float");

                    b.Property<Guid>("TimeTrackingModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TimeTrackingModelId");

                    b.ToTable("HourModels");
                });

            modelBuilder.Entity("zenTime.Shared.TimeTrackingModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TimeTracking");
                });

            modelBuilder.Entity("zenTime.Shared.HourModel", b =>
                {
                    b.HasOne("zenTime.Shared.TimeTrackingModel", "TimeTrackingModel")
                        .WithMany("Hours")
                        .HasForeignKey("TimeTrackingModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TimeTrackingModel");
                });

            modelBuilder.Entity("zenTime.Shared.TimeTrackingModel", b =>
                {
                    b.Navigation("Hours");
                });
#pragma warning restore 612, 618
        }
    }
}
