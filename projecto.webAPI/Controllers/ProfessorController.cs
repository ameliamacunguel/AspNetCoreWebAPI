using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projecto.webAPI.Models;
using projecto.webAPI.Data;

namespace projecto.webAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController(Projecto context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }
        // public IActionResult Get()
        // {
        //    return Ok("Professores: Marta, Paula, Lucas, Rafa ");  
        // }
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _context.Professores.FirstOrDefault(a =>  a.Id ==  id);
            if (professor == null) return BadRequest("O Professor não foi encontrado");
  
            return Ok(professor);
        }

            //api/aluno/nome
        [HttpGet("{ByNome}")]
        public IActionResult GetById(string nome, string Sobrenome)
        {
            var professor = _context.Professores.FirstOrDefault(a =>  a.Nome.Contains (nome) &&  a.Sobrenome.Contains(Sobrenome)
             );
            if (professor == null) return BadRequest("O Professor não foi encontrado");
  
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult PostProfessor(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Professor professor)
        {
             var alu = _context.Professores.FirstOrDefault(a =>  a.Id ==  id);
                if(alu == null) return BadRequest("Professor não encontrado");
           
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id,Professor professor)
        {
            var prof = _context.Professores.FirstOrDefault(a =>  a.Id ==  id);
                if(prof == null) return BadRequest("Professor não encontrado");
            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _context.Professores.FirstOrDefault(a =>  a.Id ==  id);
                if(professor == null) return BadRequest("Professor não encontrado");
            _context.Remove(professor);
            _context.SaveChanges();
            return Ok();
        }

    }
    }
