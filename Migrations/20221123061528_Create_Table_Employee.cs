using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranHoangChungBTH2.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Faculty_FacultyID",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "FacultyID",
                table: "Student",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employee",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Faculty_FacultyID",
                table: "Student",
                column: "FacultyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Faculty_FacultyID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "FacultyID",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Faculty_FacultyID",
                table: "Student",
                column: "FacultyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
