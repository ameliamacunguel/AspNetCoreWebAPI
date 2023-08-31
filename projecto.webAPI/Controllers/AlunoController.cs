using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using projecto.webAPI.Models;
using projecto.webAPI.Data;
using projecto.webAPI.Dtos;
using AutoMapper;
using System.Data.SqlTypes;
using Microsoft.AspNetCore.Http.HttpResults;

namespace projecto.webAPI.Controllers
{

   [ApiController] 
   [Route("api/[controller]")]

    public class AlunoController : ControllerBase
    {
        // Private ReadOnly Projectocontext _Context;

        public readonly IRepository _repo;
        
        public readonly IMapper _mapper;

        public AlunoController(IRepository repo, IMapper mapper)
        {
            _mapper  = mapper;
            _repo = repo;
            // _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var alunos = _repo.GetAllAlunos(true);

             return Ok(_mapper.Map<IEnumerable<AlunoDto>>(alunos));

        }
        //      var alunosRetorno = new List<AlunoDto>();

        //     foreach(var aluno in alunos)
        //     {
        //         alunosRetorno.Add(new AlunoDto(){
        //             Id = aluno.Id,
        //             Matricula = aluno.Matricula,
        //             Nome = $"{aluno.Nome} {aluno.Sobrenome}",
        //             Telefone = aluno.Telefone,
        //             // DataNasc = aluno.DataNasc,
        //             DataIni = aluno.DataIni,
        //             Ativo = aluno.Ativo
        //         });

        //     }       
        //     return Ok(alunosRetorno);

            // registar aluno na Dto
        [HttpGet("getRegister")]
        public IActionResult GetRegister()
        {

            var alunos = _repo.GetAllAlunos(true);

             return Ok(new AlunoRegistrarDto());/*registar novo aluno na base de dados*/

        }
         
        
        //api/aluno
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // var aluno = _context.Alunos.FirstOrDefault(a =>  a.Id ==  id);
            var aluno = _repo.GetAlunoById(id, false);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");

            var alunoDto = _mapper.Map<AlunoDto>(aluno);

            return Ok(alunoDto);
        }

        //     //api/aluno/nome
        // [HttpGet("{ByNome}")]
        // public IActionResult GetById(string nome, string Sobrenome)
        // {
        //     var aluno = _context.Alunos.FirstOrDefault(a =>  a.Nome.Contains (nome) &&  a.Sobrenome.Contains(Sobrenome)
        //      );
        //     if (aluno == null) return BadRequest("O Aluno não foi encontrado");
  
        //     return Ok(aluno);
        // }

        [HttpPost]
        public IActionResult Post(AlunoRegistrarDto model)
        {
            var aluno = _mapper.Map<Aluno>(model);
            

            _repo.Add(aluno);
            if (_repo.SaveChanges())
            {
              return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));  
            }

                return BadRequest ("Aluno não Cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,AlunoRegistrarDto model)
        {
            //  var alu = _context.Alunos.FirstOrDefault(a =>  a.Id ==  id);
                var aluno = _repo.GetAlunoById(id);
                if(aluno == null) return BadRequest("Aluno não encontrado");
           
            _mapper.Map(model, aluno);

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
              return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));  
             
            }
            return BadRequest ("Aluno não Actualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id,AlunoRegistrarDto model)
        {
           var aluno = _repo.GetAlunoById(id);
                if(aluno == null) return BadRequest("Aluno não encontrado");
           
           _mapper.Map(model, aluno);

           _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
              return Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno));  
             
            }
            return BadRequest ("Aluno não Actualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAlunoById(id);
                if(aluno == null) return BadRequest("Aluno não encontrado");
           
            _repo.Delete(aluno);
            if (_repo.SaveChanges())
            {
              return Ok("Aluno deletado");  
            }
            return BadRequest ("Aluno não delettado");
        }

    }
    
}
