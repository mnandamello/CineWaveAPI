﻿// <auto-generated />
using CineWaveAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace CineWaveAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CineWaveAPI.Models.Campanha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AgeRange")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<float>("Budget")
                        .HasColumnType("BINARY_FLOAT");

                    b.Property<string>("GenderMovie")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ReachExpectations")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Campanhas");
                });

            modelBuilder.Entity("CineWaveAPI.Models.InsightMock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AverageCostPerClick")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<int>("ConversionPrediction")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("MarketingChannel")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("RoiForecast")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Insights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageCostPerClick = 1.5,
                            ConversionPrediction = 250,
                            MarketingChannel = "TikTok",
                            MovieTitle = "Gafield 2",
                            RoiForecast = 250000
                        },
                        new
                        {
                            Id = 2,
                            AverageCostPerClick = 1.3,
                            ConversionPrediction = 340,
                            MarketingChannel = "Instagram",
                            MovieTitle = "Moana 2",
                            RoiForecast = 10000000
                        });
                });

            modelBuilder.Entity("CineWaveAPI.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("Password")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
