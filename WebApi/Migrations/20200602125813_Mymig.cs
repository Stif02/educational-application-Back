using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApi.Migrations
{
    public partial class Mymig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QSelectOutOfFourDTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    task = table.Column<string>(nullable: true),
                    answerString = table.Column<string>(nullable: true),
                    variant1 = table.Column<string>(nullable: true),
                    variant2 = table.Column<string>(nullable: true),
                    variant3 = table.Column<string>(nullable: true),
                    variant4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QSelectOutOfFourDTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QSelectOutOfFours",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    task = table.Column<string>(nullable: true),
                    answerString = table.Column<string>(nullable: true),  
                    variant1 = table.Column<string>(nullable: true),
                    variant2 = table.Column<string>(nullable: true),
                    variant3 = table.Column<string>(nullable: true),
                    variant4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QSelectOutOfFours", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QSelectOutOfThreePics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    task = table.Column<string>(nullable: true),
                    answerString = table.Column<string>(nullable: true),
                    variant1 = table.Column<string>(nullable: true),
                    variant2 = table.Column<string>(nullable: true),
                    variant3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QSelectOutOfThreePics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QWriteRightAnswers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    task = table.Column<string>(nullable: true),
                    answerString = table.Column<string>(nullable: true),
                    variant1 = table.Column<string>(nullable: true),
                    variant2 = table.Column<string>(nullable: true),
                    variant3 = table.Column<string>(nullable: true),
                    variant4 = table.Column<string>(nullable: true),
                    variant5 = table.Column<string>(nullable: true),
                    variant6 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QWriteRightAnswers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QSelectOutOfFourDTO");

            migrationBuilder.DropTable(
                name: "QSelectOutOfFours");

            migrationBuilder.DropTable(
                name: "QSelectOutOfThreePics");

            migrationBuilder.DropTable(
                name: "QWriteRightAnswers");
        }
    }
}
