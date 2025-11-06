using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Distribuidos.Api.Services.Pipedream;
using Distribuidos.Api.Models.Pipedream;

namespace MyApp.Namespace
{
    [Route("api/pipedream")]
    [ApiController]
    public class PipedreamController : ControllerBase
    {

        //instancia del servicio
        private readonly IPipedreamService _pipedreamService;

        //constructor
        public PipedreamController(IPipedreamService pipedreamService)
        {
            //inicializacion del servicio
            _pipedreamService = pipedreamService;
        }

        [HttpPost("welcome")]
        public async Task<IActionResult> WelcomeEmail([FromBody] WelcomeModel body)
        {
            try
            {
                bool res = await _pipedreamService.setWelcomeData(body);

                return Ok(new {
                    error = false,
                    msjg = res,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new {
                    error = true,
                    msjg = ex.Message,
                });
            }
        }
        [HttpPost("sendcode")]
        public async Task<IActionResult> SendCode([FromBody] WelcomeModel body)
        {
            try
            {
                bool res = await _pipedreamService.setCode(body);

                return Ok(new {
                    error = false,
                    msjg = res,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new {
                    error = true,
                    msjg = ex.Message,
                });
            }
        }
        [HttpPost("checkcode")]
        public async Task<IActionResult> CheckCode([FromBody] CheckCodeModel body)
        {
            try
            {
                bool res = await _pipedreamService.checkCode(body);

                return Ok(new {
                    error = false,
                    msjg = res,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new {
                    error = true,
                    msjg = ex.Message,
                });
            }
        }
    }
}
