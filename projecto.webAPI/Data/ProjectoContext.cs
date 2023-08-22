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
        public ProjectoContext(DbContextOptions<ProjectoContext>options): base(options){ }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }
        
        public DbSet<Disciplina> Disciplinas { get; set; }

        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Professor>()
            .HasData(new List<Professor>(){
                new Professor(1, "Lauro"),
                new Professor(2, "Roberto"),
                new Professor(3, "Ronaldo"),
                new Professor(4, "Rodrigo"),
                new Professor(5, "Alexandre"),
            });

             builder.Entity<Disciplina>()
            .HasData(new List<Disciplina>(){
                new Disciplina(1, "Matematica", 1),
                new Disciplina(2, "Fisica", 2),
                new Disciplina(3, "Portugues", 3),
                new Disciplina(4, "Ingles", 4),
                new Disciplina(5, "Progamacao", 5),
            });

            builder.Entity<Aluno>()
            .HasData(new List<Aluno>(){
                new Aluno(1, "Marta", "Kent", "33334444"),
                new Aluno(2, "Paula", "Isabela", "11112222"),
                new Aluno(3, "Laura", "Antonia", "22223333"),
                new Aluno(4, "Luiza", "Marta", "44445555"),
                new Aluno(5, "Lucas", "Machado", "55556666"),
                // new Aluno(6, "Pedro", "Alvares", "66667777"),
                // new Aluno(7, "Paulo", "Jose", "88889999"),
            });

             builder.Entity<AlunoDisciplina>()
            .HasData(new List<AlunoDisciplina>(){
                new AlunoDisciplina(){Id=1, AlunoId = 1, DisciplinaId = 1,},
                new AlunoDisciplina(){Id=2, AlunoId = 1, DisciplinaId = 1,},
                new AlunoDisciplina(){Id=3, AlunoId = 1, DisciplinaId = 1,},
                new AlunoDisciplina(){Id=4, AlunoId = 2, DisciplinaId = 2,},
                // new AlunoDisciplina(){Id=1, AlunoId = 2, DisciplinaId = 2,},
                // new AlunoDisciplina(){Id=1, AlunoId = 2, DisciplinaId = 2,},
                // new AlunoDisciplina(){Id=1, AlunoId = 3, DisciplinaId = 3,},
                // new AlunoDisciplina(){Id=1, AlunoId = 3, DisciplinaId = 3,},
                // new AlunoDisciplina(){Id=1, AlunoId = 3, DisciplinaId = 3,},
                // new AlunoDisciplina(){Id=1, AlunoId = 4, DisciplinaId = 4,},
                // new AlunoDisciplina(){Id=1, AlunoId = 4, DisciplinaId = 4,},
                // new AlunoDisciplina(){Id=1, AlunoId = 4, DisciplinaId = 4,},
                // new AlunoDisciplina(){Id=1, AlunoId = 5, DisciplinaId = 5,},
                // new AlunoDisciplina(){Id=1, AlunoId = 5, DisciplinaId = 5,},
                // new AlunoDisciplina(){Id=1, AlunoId = 6, DisciplinaId = 6,},
                // new AlunoDisciplina(){Id=1, AlunoId = 6, DisciplinaId = 6,},
                // new AlunoDisciplina(){Id=1, AlunoId = 6, DisciplinaId = 6,},
                // new AlunoDisciplina(){Id=1, AlunoId = 6, DisciplinaId = 6,},
                // new AlunoDisciplina(){Id=1, AlunoId = 7, DisciplinaId = 7,},
                // new AlunoDisciplina(){Id=1, AlunoId = 7, DisciplinaId = 7,},
                // new AlunoDisciplina(){Id=1, AlunoId = 7, DisciplinaId = 7,},
                // new AlunoDisciplina(){Id=1, AlunoId = 7, DisciplinaId = 7,},
                // new AlunoDisciplina(){Id=1, AlunoId = 7, DisciplinaId = 7,},
            });

            builder.Entity<AlunoTeste>()
            .HasData(new List<AlunoTeste>(){
                new AlunoTeste(1, "Marta", "Kent", "33334444"),
                new AlunoTeste(2, "Paula", "Isabela", "11112222"),
                new AlunoTeste(3, "Laura", "Antonia", "22223333"),
                new AlunoTeste(4, "Luiza", "Marta", "44445555"),
                new AlunoTeste(5, "Lucas", "Machado", "55556666"),
            });
        }
    }
}