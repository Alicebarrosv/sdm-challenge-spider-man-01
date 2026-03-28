using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpiderNetApi.Models;

namespace SpiderNetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissoesController : ControllerBase
    {
        private static List<MissaoAranha> _missoes = new();

        [HttpGet]
        public ActionResult<IEnumerable<MissaoAranha>> Get()
        {
            return Ok(_missoes);
        }
        [HttpPost]
        public IActionResult Post([FromBody] MissaoAranha novamissao)
        {
            if (novamissao.NivelPerigo < 1 || novamissao.NivelPerigo > 10)
        {
        return BadRequest("O campo NivelPerigo deve estar entre 1 e 10.");
        }

            _missoes.Add(novamissao);
            return CreatedAtAction(nameof(Get),new {ide = novamissao.Id}, novamissao);
        }
        
    }
}