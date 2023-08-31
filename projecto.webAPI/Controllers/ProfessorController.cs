using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projecto.webAPI.Models;
using projecto.webAPI.Data;
using AutoMapper;
using projecto.webAPI.Dtos;

namespace projecto.webAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProfessorController : ControllerBase
    {
        
        // private readonly ProjectoContext _context;

        public readonly IRepository _repo;

        public readonly IMapper _mapper;
        public ProfessorController(IRepository repo, IMapper mapper)
        {
           _mapper = mapper;
            _repo = repo;
            // _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var professores = _repo.GetAllProfessores(true);
            return Ok(_mapper.Map<IEnumerable<ProfessorDto>>(professores));

        }
        // public IActionResult Get()
        // {
        //    return Ok("Professores: Marta, Paula, Lucas, Rafa ");  
        // }

             // registar professor na Dto
        [HttpGet("getRegister")]
        public IActionResult GetRegister()
        {

            var professores = _repo.GetAllProfessores(true);

             return Ok(new ProfessorRegistarDto());/*registar novo professor na base de dados*/

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // var professor = _context.Professores.FirstOrDefault(a =>  a.Id ==  id);
            var professor= _repo.GetProfessorById(id, false);
            if (professor == null) return BadRequest("O Professor não foi encontrado");

            var professorDto = _mapper.Map<ProfessorDto>(professor);

            return Ok(professorDto);
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
        public IActionResult PostProfessor(ProfessorRegistarDto model)
        {
          var professor = _mapper.Map<Professor>(model);

           _repo.Add(professor);
            if (_repo.SaveChanges())
            {
            return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));  
             
            }

                return BadRequest ("Professor não Cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistarDto model)
        {
             var professor = _repo.GetProfessorById(id, false);
                if(professor == null) return BadRequest("Professor não encontrado");
          
           _mapper.Map(model, professor); 

           _repo.Update(professor);
            if (_repo.SaveChanges())
            {
              return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));  
              
            }

                return BadRequest ("Professor não Actualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorRegistarDto model)
        {
            var professor = _repo.GetProfessorById(id, false);
                if(professor == null) return BadRequest("Professor não encontrado");
           
           _mapper.Map(model, professor); 
           
           _repo.Update(professor);
            if (_repo.SaveChanges())
            {
             return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));  
              
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
