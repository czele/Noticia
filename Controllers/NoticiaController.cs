using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XNews.Service;

namespace XNews.Controllers
{
    [Route("[controller]")]
    public class NoticiaController : ControllerBase
    {
        private NoticiaService _noticiaService = new NoticiaService();

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            try
            {
                var resultado = _noticiaService.Listar();
                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            }
            catch 
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
