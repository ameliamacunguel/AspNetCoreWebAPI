using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using projecto.webAPI.Models;
using projecto.webAPI.Data;



namespace projecto.webAPI.Controllers
{

   [ApiController] 
   [Route("api/[controller]")]

    public class AlunoController : ControllerBase
    {
        private readonly ProjectoContext _context;

        public AlunoController(ProjectoContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Alunos);
        }
        //api/aluno/byId
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a =>  a.Id ==  id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
  
            return Ok(aluno);
        }

            //api/aluno/nome
        [HttpGet("{ByNome}")]
        public IActionResult GetById(string nome, string Sobrenome)
        {
            var aluno = _context.Alunos.FirstOrDefault(a =>  a.Nome.Contains (nome) &&  a.Sobrenome.Contains(Sobrenome)
             );
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");
  
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult PostAluno(Aluno aluno)
        {
            _context.Add(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Aluno aluno)
        {
             var alu = _context.Alunos.FirstOrDefault(a =>  a.Id ==  id);
                if(alu == null) return BadRequest("Aluno não encontrado");
           
            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id,Aluno aluno)
        {
            var alu = _context.Alunos.FirstOrDefault(a =>  a.Id ==  id);
                if(alu == null) return BadRequest("Aluno não encontrado");
            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a =>  a.Id ==  id);
                if(aluno == null) return BadRequest("Aluno não encontrado");
            _context.Remove(aluno);
            _context.SaveChanges();
            return Ok();
        }

    }
    
}
