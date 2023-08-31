using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecto.webAPI.Dtos
{
    public class ProfessorRegistarDto
    {
        public int Id { get; set; } 

        public int Registro { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public DateTime DataIni { get; set; } = DateTime.Now;

        public DateTime? DataFim { get; set; } = null;
        
        public bool Ativo { get; set; } = true;
    }
}