using Microsoft.AspNetCore.Mvc;
using puc_conversao_temperatura.Models;
using System.Threading.Tasks;

namespace puc_conversao_temperatura.Controllers
{
    [Route("api/celsius")]
    [ApiController]
    public class ConversaoCelsiusController : ControllerBase
    {
        [HttpPost("kelvin")]
        public async Task<IActionResult> ConverterCelsiusParaKelvin([FromBody] Temperatura temperatura)
        {
            return Ok($"{temperatura.ConvertCelsiusToKelvin()} K");
        }
    }
}
