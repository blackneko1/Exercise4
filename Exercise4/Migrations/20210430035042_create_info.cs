using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercise4.Migrations
{
    public partial class create_info : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idnumber = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Course = table.Column<string>(maxLength: 50, nullable: false),
                    Year = table.Column<string>(nullable: false),
                    TshirtColor = table.Column<string>(maxLength: 50, nullable: false),
                    Size = table.Column<string>(maxLength: 50, nullable: false),
                    AmountPaid = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentModel");
        }
    }
}
