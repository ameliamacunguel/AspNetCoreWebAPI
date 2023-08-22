using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace projecto.webAPI.Models
{
    public class Aluno
    {
      public Aluno(){}
        public Aluno(int id, string nome, string sobrenome, string telefone) 
        {
            this.Id = id;
            this.Nome = telefone;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
   
        }
      public int Id { get; set; }  
      public string Nome { get; set; }
      public string Sobrenome { get; set; }

      public string Telefone { get; set; }

        public IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }

        internal static object FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}