using AutoMapper;
using CompareRemedios.Dominio.Dtos;
using CompareRemedios.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.Map
{
    public class EntityToDtoMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Produto, ProdutoDto>();
            Mapper.CreateMap<Preco, PrecoDto>()
                .ForMember(p => p.NomeFarmacia, op => op.MapFrom(f => f.Farmacia.NomeFantasia))
                .ForMember(p => p.NomeRemedio, op => op.MapFrom(r => r.Produto.Descricao))
                .ForMember(p => p.Preco, op => op.MapFrom(r => r.Valor.ToString()));


        }
    }
}
