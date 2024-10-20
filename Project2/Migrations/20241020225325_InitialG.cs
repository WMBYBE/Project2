using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project2.Migrations
{
    public partial class InitialG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaCritic = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Developer", "MetaCritic", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Ryu Ga Gotoku", 89, "Like A Dragon: Infinite Wealth", "January 25th" },
                    { 2, "Atlus", 87, "Persona 3 Reload", "Febuary 1st" },
                    { 3, "Square Enix Creative Buisiness Unit 1", 92, "Final Fantasy VII Rebirth", "Febuary 29th" },
                    { 4, "Capcom", 92, "Dragons Dogma 2", "March 21st" },
                    { 5, "Atlus", 94, "Metaphor: Refantazio", "October 11" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
