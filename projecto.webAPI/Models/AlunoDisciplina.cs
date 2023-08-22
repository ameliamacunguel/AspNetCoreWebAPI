using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace projecto.webAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina(){}
        public AlunoDisciplina(int id, int  alunoId, int disciplinaId) 
        {
            this.Id = id;
            this.AlunoId =  alunoId;
            this.DisciplinaId = disciplinaId;
   
        }
        public int Id { get; set; }
        public int AlunoId { get; set; }
        //public int Aluno { get; set; }
        public int DisciplinaId { get; set; }
        //public int Disciplina{ get; set; }
    }
}