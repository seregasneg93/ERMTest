using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ERMTest.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataPK",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FreeOfMemory = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalMemory = table.Column<decimal>(type: "numeric", nullable: false),
                    UsageCPU = table.Column<decimal>(type: "numeric", nullable: false),
                    FreeDisks = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalDisks = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPK", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataPK");
        }
    }
}
