using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Covid19KeralaApi.Migrations
{
    public partial class DistrictCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistrictCounts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Kasaragod = table.Column<int>(nullable: true),
                    Kannur = table.Column<int>(nullable: true),
                    Kozhikode = table.Column<int>(nullable: true),
                    Wayanad = table.Column<int>(nullable: true),
                    Malappuram = table.Column<int>(nullable: true),
                    Palakkad = table.Column<int>(nullable: true),
                    Thrissur = table.Column<int>(nullable: true),
                    Ernakulam = table.Column<int>(nullable: true),
                    Alappuzha = table.Column<int>(nullable: true),
                    Kottayam = table.Column<int>(nullable: true),
                    Idukki = table.Column<int>(nullable: true),
                    Pathanamthitta = table.Column<int>(nullable: true),
                    Kollam = table.Column<int>(nullable: true),
                    Thiruvananthapuram = table.Column<int>(nullable: true),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictCounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistrictCounts");
        }
    }
}
