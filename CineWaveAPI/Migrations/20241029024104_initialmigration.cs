using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CineWaveAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campanhas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    MovieName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MovieTitle = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    GenderMovie = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    AgeRange = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Budget = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    ReachExpectations = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UserId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campanhas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    MovieTitle = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    RoiForecast = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MarketingChannel = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    AverageCostPerClick = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    ConversionPrediction = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Uid = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "Insights",
                columns: new[] { "Id", "AverageCostPerClick", "ConversionPrediction", "MarketingChannel", "MovieTitle", "RoiForecast" },
                values: new object[,]
                {
                    { 1, 1.5, 250, "TikTok", "Gafield 2", 250000 },
                    { 2, 1.3, 340, "Instagram", "Moana 2", 10000000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campanhas");

            migrationBuilder.DropTable(
                name: "Insights");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
