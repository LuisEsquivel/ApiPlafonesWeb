using ApiPlafonesWeb.Dto.Email;
using ApiPlafonesWeb.Dto.Productos;
using ApiPlafonesWeb.Dto.Sucursales;
using ApiPlafonesWeb.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPlafonesWeb.AutoMapper
{
    public class AutoMappers : Profile
    {

        public AutoMappers()
        {
           CreateMap<SucursalesModel, SucursalesDto>().ReverseMap();

           CreateMap<ProductosModel, ProductosDto>().ReverseMap();

           CreateMap<ContactosModel, EmailDto>().ReverseMap();

           CreateMap<RequieresInstalacionModel, EmailDto>().ReverseMap();

           CreateMap<UneteModel, EmailDto>().ReverseMap();
        }
        

    }
}
