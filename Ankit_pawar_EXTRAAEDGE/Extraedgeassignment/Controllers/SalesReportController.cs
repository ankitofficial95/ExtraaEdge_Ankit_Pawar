using Extraedgeassignment.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Extraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesReportController : ControllerBase
    {
        private readonly ISalesReportService service;
        private readonly IMobileBrandWiseSalesReportService service2;
        public SalesReportController(ISalesReportService service, IMobileBrandWiseSalesReportService service2)
        {
            this.service = service;
            this.service2 = service2;
        }
        [HttpGet]
        [Route("GetSalesMonthlyReport")]
        public IActionResult GetSalesMonthlyReport(DateTime fromDate,DateTime toDate)
        {
            try
            {
                return new ObjectResult(service.GetSalesMonthlyReport(fromDate,toDate));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("MobilebrandWiseSalesReport")]
        public IActionResult GetMobilebrandWiseSalesReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return new ObjectResult(service2.MobilebrandWiseSalesReport(fromDate, toDate));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
