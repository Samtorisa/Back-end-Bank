﻿// <auto-generated />
using System;
using BankAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankAppAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230312100135_changedIndentity")]
    partial class changedIndentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BankAppAPI.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Hname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("hamount")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BankAppAPI.Models.ProccesHistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Prtype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pramount")
                        .HasColumnType("int");

                    b.Property<DateTime>("prhist")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProccesHistrys");
                });
#pragma warning restore 612, 618
        }
    }
}