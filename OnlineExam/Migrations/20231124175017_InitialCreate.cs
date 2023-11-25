using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExam.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    Answer1 = table.Column<string>(type: "TEXT", nullable: false),
                    Answer2 = table.Column<string>(type: "TEXT", nullable: false),
                    Answer3 = table.Column<string>(type: "TEXT", nullable: false),
                    Answer4 = table.Column<string>(type: "TEXT", nullable: false),
                    Answer5 = table.Column<string>(type: "TEXT", nullable: false),
                    Score = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
