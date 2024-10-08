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

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

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

                    b.Property<string>("MarketingChanne")
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
                            MarketingChanne = "TikTok",
                            MovieTitle = "Gafield 2",
                            RoiForecast = 250000
                        },
                        new
                        {
                            Id = 2,
                            AverageCostPerClick = 1.3,
                            ConversionPrediction = 340,
                            MarketingChanne = "Instagram",
                            MovieTitle = "Moana 2",
                            RoiForecast = 10000000
                        });
                });

            modelBuilder.Entity("CineWaveAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("IsActived")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
