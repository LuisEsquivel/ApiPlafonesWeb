using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPlafonesWeb.Dto.Productos;
using ApiPlafonesWeb.Helpers;
using ApiPlafonesWeb.Interface;
using ApiPlafonesWeb.Models;
using ApiPlafonesWeb.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlafonesWeb.Controllers
{
    [Route("api/productos/")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private IGenericRepository<ProductosModel> repository;
        private IMapper mapper;
        private Response response;

        public ProductosController(ApplicationDbContext context, IMapper _mapper)
        {
            this.mapper = _mapper;
            this.repository = new GenericRepository<ProductosModel>(context);
            this.response = new Response();
        }


        [HttpGet("Get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var list = repository.GetAll().Where(x=> x.EstatusBit == true);

            var listDto = new List<ProductosDto>();

            foreach (var row in list)
            {
                listDto.Add(mapper.Map<ProductosDto>(row));
            }

            return Ok(this.response.ResponseValues(this.Response.StatusCode, listDto));
        }



        [HttpPost("getbyvalues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByValues([FromBody] ProductosDto p)
        {
            var MostrarEnProductosDestacadosBit = p.MostrarEnProductosDestacadosBit != null ? true : false;
            var CveProdVar = p.CveProdVar  != null ? p.CveProdVar : "";
            var list = new List<ProductosModel>();

            if (MostrarEnProductosDestacadosBit)
            {
                list = repository.GetByValues(x => x.MostrarEnProductosDestacadosBit == MostrarEnProductosDestacadosBit).ToList();

            }
            else
            {

                if(p.CveClaseVar == null || p.CveClaseVar == "") 
                {
                    if (p.CveProdVar != null && p.CveProdVar != "")
                    {
                        list = repository.GetByValues(x => x.CveProdVar == p.CveProdVar).ToList();
                    }
                    else
                    {
                        list = repository.GetAll().ToList();
                    }
                   
                }
                else
                {
                    if(p.CveSubclaseVar != null && p.CveSubclaseVar != "")
                    {
                        list = repository.GetByValues(x => x.CveClaseVar == p.CveClaseVar &&
                                                           x.CveSubclaseVar == p.CveSubclaseVar).ToList();
                    }
                    else 
                    { 
                        list = repository.GetByValues(x => x.CveClaseVar == p.CveClaseVar).ToList(); 
                    }
                }

            }
          

            list = list.Where(x=> x.EstatusBit == true).ToList();

            var listDto = new List<ProductosDto>();

            foreach (var row in list)
            {
                listDto.Add(mapper.Map<ProductosDto>(row));
            }

            return Ok(this.response.ResponseValues(this.Response.StatusCode, listDto.OrderBy(x=> x.OrdenCategoriaInt)));
        }


    }


}
