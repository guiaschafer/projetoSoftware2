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
    public class DtoToEntityMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ProdutoDto, Produto>();
            Mapper.CreateMap<PrecoDto, Preco>()
                .ForMember(p => p.Valor, op => op.MapFrom(d=> Decimal.Parse(d.Preco.Replace(".",","))));

        }
    }
}
