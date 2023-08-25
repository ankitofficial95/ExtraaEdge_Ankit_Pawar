using Extraedgeassignment.Model;
using Extraedgeassignment.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Extraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService service;
        public BrandController(IBrandService service)
        {
            this.service = service;
        }
        // GET: api/<BrandController>
        [HttpGet]
        [Route("GetAllBrand")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.GetAllBrand());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<BrandController>/5
        [HttpGet]
        [Route("GetBrandById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.GetBrandById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // POST api/<BrandController>
        [HttpPost]
        [Route("AddBrand")]
        public IActionResult Post([FromBody] Brand brand)
        {
            try
            {
                int result = service.AddBrand(brand);
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
        [Route("UpdateBrand")]
        public IActionResult Put([FromBody] Brand brand)
        {
            try
            {
                int result = service.UpdateBrand(brand);
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
        [Route("DeleteBrand/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteBrand(id);
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
