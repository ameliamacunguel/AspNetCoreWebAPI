using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecto.webAPI.Models
{
    public class AlunoCurso
    {
        public AlunoCurso(){}

        public AlunoCurso(int id, int alunoId, int cursoId) 
        {
            this.Id = id;
            this.AlunoId =  alunoId;
            this.CursoId = cursoId;
   
        }
        public DateTime DataIni { get; set; } = DateTime.Now;
        
        public DateTime? DataFim { get; set; }

        public int AlunoId { get; set; }
        
        public Aluno Aluno { get; set; }
        
        public int CursoId { get; set; }
        
        public Curso Curso{ get; set; }

        public int Id {get; set;}
  
    }
}