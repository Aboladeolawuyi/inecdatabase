﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace inecdatabase.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20231024185827_InitialCreate11")]
    partial class InitialCreate11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("votes", b =>
                {
                    b.Property<int>("SerialNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SerialNumber"));

                    b.Property<int>("A")
                        .HasColumnType("integer");

                    b.Property<int>("AAC")
                        .HasColumnType("integer");

                    b.Property<int>("ADC")
                        .HasColumnType("integer");

                    b.Property<int>("ADP")
                        .HasColumnType("integer");

                    b.Property<int>("APC")
                        .HasColumnType("integer");

                    b.Property<int>("APM")
                        .HasColumnType("integer");

                    b.Property<int>("APP")
                        .HasColumnType("integer");

                    b.Property<int>("BP")
                        .HasColumnType("integer");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LP")
                        .HasColumnType("integer");

                    b.Property<int>("NNPP")
                        .HasColumnType("integer");

                    b.Property<int>("NRM")
                        .HasColumnType("integer");

                    b.Property<string>("NameOfRA")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfAccreditedVoters")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfRegisteredVoters")
                        .HasColumnType("integer");

                    b.Property<int>("PDP")
                        .HasColumnType("integer");

                    b.Property<int>("PRP")
                        .HasColumnType("integer");

                    b.Property<int>("RejectedVotes")
                        .HasColumnType("integer");

                    b.Property<int>("SDP")
                        .HasColumnType("integer");

                    b.Property<int>("TotalValidVotes")
                        .HasColumnType("integer");

                    b.Property<int>("YPP")
                        .HasColumnType("integer");

                    b.Property<int>("ZLP")
                        .HasColumnType("integer");

                    b.HasKey("SerialNumber");

                    b.ToTable("votes");
                });
#pragma warning restore 612, 618
        }
    }
}
