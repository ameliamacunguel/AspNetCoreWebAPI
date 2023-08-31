using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using projecto.webAPI.Dtos;
using projecto.webAPI.Models;

namespace projecto.webAPI.Helpers
{
    public class ProjectoProfile : Profile
    {
        public ProjectoProfile()
        {
            CreateMap<Aluno, AlunoDto>()
                .ForMember(
                    dest => dest.Nome,
                    opt => opt.MapFrom(src => $"{src.Nome} {src.Sobrenome}")
                )
            
                .ForMember(
                    dest => dest.Idade,
                    opt => opt.MapFrom(src => src.DataNasc.GetCurrentAge())
                );

                // mapeamento 
            CreateMap<AlunoDto, Aluno>(); /*adicionado aluno na base de dados*/
            CreateMap<Aluno, AlunoRegistrarDto>().ReverseMap();

            CreateMap<ProfessorDto, Professor>();/*adicionando professor na base de dados*/
            CreateMap<Professor, ProfessorRegistarDto>().ReverseMap();
        }    
    }
}