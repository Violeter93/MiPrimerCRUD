using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiPrimerCRUD.Migrations
{
    public partial class v22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlumnoCurso_Alumnos_MatriculasId",
                table: "AlumnoCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_AlumnoCurso_Cursos_MatriculasId1",
                table: "AlumnoCurso");

            migrationBuilder.RenameColumn(
                name: "MatriculasId1",
                table: "AlumnoCurso",
                newName: "CursosId");

            migrationBuilder.RenameColumn(
                name: "MatriculasId",
                table: "AlumnoCurso",
                newName: "AlumnosId");

            migrationBuilder.RenameIndex(
                name: "IX_AlumnoCurso_MatriculasId1",
                table: "AlumnoCurso",
                newName: "IX_AlumnoCurso_CursosId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlumnoCurso_Alumnos_AlumnosId",
                table: "AlumnoCurso",
                column: "AlumnosId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlumnoCurso_Cursos_CursosId",
                table: "AlumnoCurso",
                column: "CursosId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlumnoCurso_Alumnos_AlumnosId",
                table: "AlumnoCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_AlumnoCurso_Cursos_CursosId",
                table: "AlumnoCurso");

            migrationBuilder.RenameColumn(
                name: "CursosId",
                table: "AlumnoCurso",
                newName: "MatriculasId1");

            migrationBuilder.RenameColumn(
                name: "AlumnosId",
                table: "AlumnoCurso",
                newName: "MatriculasId");

            migrationBuilder.RenameIndex(
                name: "IX_AlumnoCurso_CursosId",
                table: "AlumnoCurso",
                newName: "IX_AlumnoCurso_MatriculasId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AlumnoCurso_Alumnos_MatriculasId",
                table: "AlumnoCurso",
                column: "MatriculasId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlumnoCurso_Cursos_MatriculasId1",
                table: "AlumnoCurso",
                column: "MatriculasId1",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
