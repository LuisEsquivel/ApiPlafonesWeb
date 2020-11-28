using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPlafonesWeb.Dto.Email;
using ApiPlafonesWeb.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace ApiPlafonesWeb.Controllers
{
    [Route("api/email/")]
    [ApiController]
    public class EmailController : ControllerBase
    {

        private Generals generals;
        public EmailController()
        {
            generals = new Generals();
        }


        [HttpPost("send")]
        public string Send([FromBody] EmailDto EmailDto)
        {
            var ajas = EmailDto.CorreoVar;
            string message = "";

            try
            {
                generals = new Generals();
                
                if (generals.SendEmailToBd(EmailDto) && generals.SendEmailSMTP(EmailDto))
                {
                    message = "success";
                }
                else
                {
                   message = "error";
                }

            }
            catch (Exception)
            {
                return JsonConvert.SerializeObject( message );
            }

            return JsonConvert.SerializeObject( message );
        }


    }
}
