using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPlafonesWeb.Dto.Sucursales;
using ApiPlafonesWeb.Helpers;
using ApiPlafonesWeb.Interface;
using ApiPlafonesWeb.Models;
using ApiPlafonesWeb.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlafonesWeb.Controllers
{

    [Route("api/sucursales/")]
    public class SucursalesController : Controller
    {


        private IGenericRepository<SucursalesModel> repository;
        private IMapper mapper;
        private Response response;

        public SucursalesController(ApplicationDbContext context, IMapper _mapper)
        {
            this.mapper = _mapper;
            this.repository = new GenericRepository<SucursalesModel>(context);
            this.response = new Response();
        }


        [HttpGet("Get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var list = repository.GetAll();

            var listDto = new List<SucursalesDto>();

            foreach (var row in list)
            {
                listDto.Add(mapper.Map<SucursalesDto>(row));
            }

            return Ok(this.response.ResponseValues(this.Response.StatusCode, listDto));
        }

    }
}
