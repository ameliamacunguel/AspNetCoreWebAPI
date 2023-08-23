using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace projecto.webAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedNewEntitiesOnModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Matricula = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunoTeste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoTeste", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Registro = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: false),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlunosCursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosCursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    CargaHoraria = table.Column<int>(type: "INTEGER", nullable: false),
                    PrerequisitoId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProfessorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Disciplinas_PrerequisitoId",
                        column: x => x.PrerequisitoId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataIni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Nota = table.Column<int>(type: "INTEGER", nullable: true),
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplinaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AlunoTeste",
                columns: new[] { "Id", "Nome", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, "Marta", "Kent", "33334444" },
                    { 2, "Paula", "Isabela", "11112222" },
                    { 3, "Laura", "Antonia", "22223333" },
                    { 4, "Luiza", "Marta", "44445555" },
                    { 5, "Lucas", "Machado", "55556666" }
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Ativo", "DataFim", "DataIni", "DataNasc", "Matricula", "Nome", "Sobrenome", "Telefone" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4559), new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Marta", "Kent", "33334444" },
                    { 2, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4577), new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Paula", "Isabela", "11112222" },
                    { 3, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4586), new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Laura", "Antonia", "22223333" },
                    { 4, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4595), new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Luiza", "Marta", "44445555" },
                    { 5, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4603), new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Lucas", "Machado", "55556666" },
                    { 6, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4614), new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Pedro", "Alvares", "66667777" },
                    { 7, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4623), new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Paulo", "Jose", "88889999" }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Tecnologia de Informacao" },
                    { 2, "Sistemas de Informacao" },
                    { 3, "Ciencia da Computacao" }
                });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Ativo", "DataFim", "DataIni", "Nome", "Registro", "Sobrenome" },
                values: new object[,]
                {
                    { 1, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4245), "Lauro", 1, "Oliveira" },
                    { 2, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4268), "Roberto", 2, "Soares" },
                    { 3, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4270), "Ronaldo", 3, "Marconi" },
                    { 4, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4271), "Rodrigo", 4, "Carvalho" },
                    { 5, true, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4273), "Alexandre", 5, "Montanha" }
                });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "CargaHoraria", "CursoId", "Nome", "PrerequisitoId", "ProfessorId" },
                values: new object[,]
                {
                    { 1, 0, 1, "Matematica", null, 1 },
                    { 2, 0, 3, "Matematica", null, 1 },
                    { 3, 0, 3, "Física", null, 2 },
                    { 4, 0, 1, "Portugues", null, 3 },
                    { 5, 0, 1, "Ingles", null, 4 },
                    { 6, 0, 2, "Ingles", null, 4 },
                    { 7, 0, 3, "Ingles", null, 4 },
                    { 8, 0, 1, "Programação", null, 5 },
                    { 9, 0, 2, "Programação", null, 5 },
                    { 10, 0, 3, "Programação", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "Id", "AlunoId", "DataFim", "DataIni", "DisciplinaId", "Nota" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4674), 1, null },
                    { 2, 1, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4678), 1, null },
                    { 3, 1, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4680), 1, null },
                    { 4, 2, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4682), 2, null },
                    { 5, 2, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4684), 2, null },
                    { 6, 2, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4687), 2, null },
                    { 7, 3, null, new DateTime(2023, 8, 15, 12, 17, 49, 989, DateTimeKind.Local).AddTicks(4689), 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunosCursos_AlunoId",
                table: "AlunosCursos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosCursos_CursoId",
                table: "AlunosCursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_AlunoId",
                table: "AlunosDisciplinas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_PrerequisitoId",
                table: "Disciplinas",
                column: "PrerequisitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunosCursos");

            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "AlunoTeste");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
