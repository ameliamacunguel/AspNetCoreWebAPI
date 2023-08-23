using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projecto.webAPI.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 53, 13, 791, DateTimeKind.Local).AddTicks(6234));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4273));
        }
    }
}
