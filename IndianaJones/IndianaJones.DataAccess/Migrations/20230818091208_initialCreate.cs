using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndianaJones.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Player",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Player", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_QA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    AnswerNum = table.Column<int>(type: "int", nullable: true),
                    AnswerDescribe = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    QALevel = table.Column<int>(type: "int", nullable: true),
                    Situation = table.Column<string>(type: "char(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_QA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Rewards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RewardLevel = table.Column<int>(type: "int", nullable: true),
                    Situation = table.Column<string>(type: "char(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Rewards", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Player");

            migrationBuilder.DropTable(
                name: "Tbl_QA");

            migrationBuilder.DropTable(
                name: "Tbl_Rewards");
        }
    }
}
