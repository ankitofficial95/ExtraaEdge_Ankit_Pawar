using Extraedgeassignment.Model;
using Extraedgeassignment.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Extraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellController : ControllerBase
    {
        private readonly ISellService service;
        public SellController(ISellService service)
        {
            this.service = service;
        }
        // GET: api/<SellController>
        [HttpGet]
        [Route("GetAllSell")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.GetAllSell());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<BrandController>/5
        [HttpGet]
        [Route("GetSellById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.GetSellById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // POST api/<BrandController>
        [HttpPost]
        [Route("AddSell")]
        public IActionResult Post([FromBody] Sell sell)
        {
            try
            {
                int result = service.AddSell(sell);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<BrandController>/5
        [HttpPut]
        [Route("UpdateSell")]
        public IActionResult Put([FromBody] Sell sell)
        {
            try
            {
                int result = service.UpdateSell(sell);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<BrandController>/5
        [HttpDelete]
        [Route("DeleteSell/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteSell(id);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
