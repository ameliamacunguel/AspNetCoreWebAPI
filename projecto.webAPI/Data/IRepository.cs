using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projecto.webAPI.Models;

namespace projecto.webAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        // //ALUNOS
        // Aluno [] GetAllAlunos();
        // Aluno [] GetAllAlunosByDisciplinaId();
        // Aluno GetAlunoById();

        // //PROFESSORES
        // Professor [] GetAllProfessores();
        // Professor [] GetAllProfessoresByDisciplinaId();
        // Professor GetProfessoreById();

        //Aluno
        Aluno[] GetAllAlunos(bool includeProfessor = false);
        Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
        Aluno GetAlunoById(int alunoId, bool includeProfessor = false);
        
        //Professor
        Professor[] GetAllProfessores(bool includeAlunos = false);
        Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false);
        Professor GetProfessorById(int professorId, bool includeProfessor = false);


    
    }

}