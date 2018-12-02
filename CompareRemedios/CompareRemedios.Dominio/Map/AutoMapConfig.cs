using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.Map
{
    public class AutoMapConfig
    {
        public static void Register()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DtoToEntityMappingProfile>();
                x.AddProfile<EntityToDtoMappingProfile>();
            });
        }
    }
}
