using Extraedgeassignment.Model;
using Extraedgeassignment.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Extraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;
        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }
        // GET: api/<BrandController>
        [HttpGet]
        [Route("GetAllCustomer")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.GetAllCustomer());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<BrandController>/5
        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.GetCustomerById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // POST api/<BrandController>
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult Post([FromBody] Customer cust)
        {
            try
            {
                int result = service.AddCustomer(cust);
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
        [Route("UpdateCustomer")]
        public IActionResult Put([FromBody] Customer cust)
        {
            try
            {
                int result = service.UpdateCustomer(cust);
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
        [Route("DeleteCustomer/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteCustomer(id);
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
