using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebEmpleado.Migrations
{
    public partial class fixestesí : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(50)",
                table: "Empleados",
                newName: "Apellido");

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Empleados",
                type: "varchar (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Empleados",
                type: "varchar (50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Empleados",
                type: "varchar (50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Empleados",
                newName: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(50)",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (50)");
        }
    }
}
