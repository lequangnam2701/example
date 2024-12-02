using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eLearning.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "EnrollmentForm",
                newName: "StatusId");

            migrationBuilder.CreateTable(
                name: "StatusModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnrollmentForm_StatusId",
                table: "EnrollmentForm",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollmentForm_StatusModel_StatusId",
                table: "EnrollmentForm",
                column: "StatusId",
                principalTable: "StatusModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnrollmentForm_StatusModel_StatusId",
                table: "EnrollmentForm");

            migrationBuilder.DropTable(
                name: "StatusModel");

            migrationBuilder.DropIndex(
                name: "IX_EnrollmentForm_StatusId",
                table: "EnrollmentForm");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "EnrollmentForm",
                newName: "Status");
        }
    }
}
