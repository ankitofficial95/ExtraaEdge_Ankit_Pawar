using Extraedgeassignment.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Extraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfitLossController : ControllerBase
    {
        private readonly IProfitLossService service;
        public ProfitLossController(IProfitLossService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("GetProfitLossReport")]
        public IActionResult GetProfitLossReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return new ObjectResult(service.GetProfitLossReport(fromDate, toDate));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

