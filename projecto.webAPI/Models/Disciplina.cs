using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace projecto.webAPI.Models
{
    public class Disciplina
    {
     public Disciplina(){}
        public Disciplina(int id, string nome , int professorId) 
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
   
        }
     public int Id { get; set; }  
     public string Nome { get; set; }
     public int ProfessorId { get; set; }
     //public string Professor  { get; set; }
     
     public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }
    }
}