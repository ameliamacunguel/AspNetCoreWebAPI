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
        
        // private readonly ProjectoContext _context;

        public readonly IRepository _repo;
        public ProfessorController(IRepository repo)
        {
            _repo = repo;
            // _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllProfessores(true);
            return Ok(result);
        }
        // public IActionResult Get()
        // {
        //    return Ok("Professores: Marta, Paula, Lucas, Rafa ");  
        // }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // var professor = _context.Professores.FirstOrDefault(a =>  a.Id ==  id);
            var professor= _repo.GetProfessorById(id, false);
            if (professor == null) return BadRequest("O Professor não foi encontrado");
  
            return Ok(professor);
        }

        //     //api/aluno/nome
        // [HttpGet("{ByNome}")]
        // public IActionResult GetById(string nome, string Sobrenome)
        // {
        //     var professor = _context.Professores.FirstOrDefault(a =>  a.Nome.Contains (nome)
        //      );
        //     if (professor == null) return BadRequest("O Professor não foi encontrado");
  
        //     return Ok(professor);
        // }

        [HttpPost]
        public IActionResult PostProfessor(Professor professor)
        {
           _repo.Add(professor);
            if (_repo.SaveChanges())
            {
              return Ok(professor);  
            }

                return BadRequest ("Professor não Cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Professor professor)
        {
             var prof = _repo.GetProfessorById(id, false);
                if(prof == null) return BadRequest("Professor não encontrado");
           
        
           _repo.Update(professor);
            if (_repo.SaveChanges())
            {
              return Ok(professor);  
            }

                return BadRequest ("Professor não Actualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id,Professor professor)
        {
            var prof = _repo.GetProfessorById(id, false);
                if(prof == null) return BadRequest("Professor não encontrado");
           
           _repo.Update(prof);
            if (_repo.SaveChanges())
            {
              return Ok(professor);  
            }

                return BadRequest ("Professor não Actualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
             var prof = _repo.GetProfessorById(id, false);
                if(prof == null) return BadRequest("Professor não encontrado");
            
            _repo.Delete(prof);
            if (_repo.SaveChanges())
            {
              return Ok("Professor deletado");  
            }

                return BadRequest ("Professor não deletado");
        }

    }
    }
