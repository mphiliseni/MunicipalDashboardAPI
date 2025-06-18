using Microsoft.AspNetCore.Mvc;
using MunicipalMoneyApi.Models;
using MunicipalMoneyApi.Services;
using System.Threading.Tasks;

namespace MunicipalMoneyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MunicipalDataController : ControllerBase
    {
        private readonly IMunicipalDataService _municipalDataService;

        public MunicipalDataController(IMunicipalDataService municipalDataService)
        {
            _municipalDataService = municipalDataService;
        }

        [HttpGet("cubefacts")]
        public async Task<ActionResult<CubeFactsResponse>> GetCubeFacts([FromQuery] string cubeName)
        {
            if (string.IsNullOrWhiteSpace(cubeName))
                return BadRequest("cubeName is required");

            var result = await _municipalDataService.GetCubeFactsAsync(cubeName);

            return Ok(result);
        }
    }
}
