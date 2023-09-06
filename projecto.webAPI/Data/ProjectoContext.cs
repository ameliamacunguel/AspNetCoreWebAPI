using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projecto.webAPI.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Data.SQLite;

 

namespace projecto.webAPI.Data
{
    public class ProjectoContext : DbContext
    {
        private const string V = "33334444";

        public ProjectoContext(DbContextOptions<ProjectoContext>options): base(options){}

        public DbSet<Aluno> Alunos { get; set; }
    

        public DbSet<AlunoCurso> AlunosCursos { get; set; }

        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public DbSet<Curso> Cursos { get; set; }
        
        public DbSet<Disciplina> Disciplinas { get; set; }

        public DbSet<Professor> Professores { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            // nao é necessario criar, para evitar conflito ao atualizar a migrations
            // builder.Entity<AlunoDisciplina>()
            // .HasKey(AD => new {AD.AlunoId, AD.DisciplinaId});

            // builder.Entity<AlunoCurso>()
            // .HasKey(AD => new {AD.AlunoId, AD.CursoId});

            _ = builder.Entity<Professor>()
            .HasData(new List<Professor>(){
                new Professor(1, 1, "Lauro", "Oliveira"),
                new Professor(2, 2,  "Roberto", "Soares"),
                new Professor(3, 3, "Ronaldo", "Marconi"),
                new Professor(4, 4, "Rodrigo", "Carvalho"),
                new Professor(5, 5, "Alexandre", "Montanha")
            });
            
            builder.Entity<Curso>()
            .HasData(new List<Curso>{
                new Curso(1, "Tecnologia de Informacao"),
                new Curso(2, "Sistemas de Informacao"),
                new Curso(3, "Ciencia da Computacao")
            });


             builder.Entity<Disciplina>()
            .HasData(new List<Disciplina>(){
                new Disciplina(1, "Matematica", 1, 1),
                new Disciplina(2, "Matematica", 1,3),
                new Disciplina(3, "Física", 2,3),
                new Disciplina(4, "Portugues", 3,1),
                new Disciplina(5, "Ingles", 4,1),
                new Disciplina(6, "Ingles", 4,2),
                new Disciplina(7, "Ingles", 4,3),
                new Disciplina(8, "Programação", 5,1),
                new Disciplina(9, "Programação", 5,2),
                new Disciplina(10, "Programação", 5,3)
            });

            builder.Entity<Aluno>()
            .HasData(new List<Aluno>(){
                new Aluno(1, 1, "Marta", "Kent", "33334444", DateTime.Parse("05/20/2005")),
                new Aluno(2, 2, "Paula", "Isabela", "11112222", DateTime.Parse("05/20/2005")),
                new Aluno(3, 3, "Laura", "Antonia", "22223333", DateTime.Parse("05/20/2005")),
                new Aluno(4, 3, "Luiza", "Marta", "44445555", DateTime.Parse("05/20/2005")),
                new Aluno(5, 5, "Lucas", "Machado", "55556666", DateTime.Parse("05/20/2005")),
                new Aluno(6, 6, "Pedro", "Alvares", "66667777", DateTime.Parse("05/20/2005")),
                new Aluno(7, 7, "Paulo", "Jose", "88889999", DateTime.Parse("05/20/2005"))
            });

             builder.Entity<AlunoDisciplina>()
            .HasData(new List<AlunoDisciplina>(){
                new AlunoDisciplina(){Id=1, AlunoId = 1, DisciplinaId = 1,},
                new AlunoDisciplina(){Id=2, AlunoId = 1, DisciplinaId = 1,},
                new AlunoDisciplina(){Id=3, AlunoId = 1, DisciplinaId = 1,},
                new AlunoDisciplina(){Id=4, AlunoId = 2, DisciplinaId = 2,},
                new AlunoDisciplina(){Id=5, AlunoId = 2, DisciplinaId = 2,},
                new AlunoDisciplina(){Id=6, AlunoId = 2, DisciplinaId = 2,},
                new AlunoDisciplina(){Id=7, AlunoId = 3, DisciplinaId = 3,},
                 new AlunoDisciplina(){Id=8, AlunoId = 3, DisciplinaId = 3,},
                new AlunoDisciplina(){Id=9, AlunoId = 3, DisciplinaId = 3,},
                new AlunoDisciplina(){Id=10, AlunoId = 4, DisciplinaId = 4,},
                new AlunoDisciplina(){Id=11, AlunoId = 4, DisciplinaId = 4,},
                new AlunoDisciplina(){Id=12, AlunoId = 4, DisciplinaId = 4,},
                new AlunoDisciplina(){Id=13, AlunoId = 5, DisciplinaId = 5,},
                new AlunoDisciplina(){Id=14, AlunoId = 5, DisciplinaId = 5,},
                new AlunoDisciplina(){Id=15, AlunoId = 6, DisciplinaId = 6,},
                new AlunoDisciplina(){Id=16, AlunoId = 6, DisciplinaId = 6,},
                new AlunoDisciplina(){Id=17, AlunoId = 6, DisciplinaId = 6,},
                new AlunoDisciplina(){Id=18, AlunoId = 6, DisciplinaId = 6,},
                new AlunoDisciplina(){Id=19, AlunoId = 7, DisciplinaId = 7,},
                new AlunoDisciplina(){Id=20, AlunoId = 7, DisciplinaId = 7,},
                new AlunoDisciplina(){Id=21, AlunoId = 7, DisciplinaId = 7,},
                new AlunoDisciplina(){Id=22, AlunoId = 7, DisciplinaId = 7,},
                new AlunoDisciplina(){Id=23, AlunoId = 7, DisciplinaId = 7,}
            });

            builder.Entity<AlunoTeste>()
            .HasData(new List<AlunoTeste>(){
                new AlunoTeste(1, "Marta", "Kent", "33334444"),
                new AlunoTeste(2, "Paula", "Isabela", "11112222"),
                new AlunoTeste(3, "Laura", "Antonia", "22223333"),
                new AlunoTeste(4, "Luiza", "Marta", "44445555"),
                new AlunoTeste(5, "Lucas", "Machado", "55556666")
            });
        }
    }
}