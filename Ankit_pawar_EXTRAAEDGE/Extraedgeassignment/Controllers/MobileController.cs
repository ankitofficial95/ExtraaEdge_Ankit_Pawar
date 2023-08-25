using Extraedgeassignment.Model;
using Extraedgeassignment.Service;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Extraedgeassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly IMobileService service;
        public MobileController(IMobileService service)
        {
            this.service = service;
        }
        
        [HttpGet]
        [Route("GetAllMobiles")]
        public IActionResult GetAllMobiles()
        {
            try
            {
                return new ObjectResult(service.GetAllMobile());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
            
        }

        // GET api/<MobileController>/5
        [HttpGet]
        [Route("GetMobileById/{id}")]
        public IActionResult GetMobileById(int id)
        {
            try
            {
                return new ObjectResult(service.GetMobileById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // POST api/<MobileController>
        [HttpPost]
        [Route("AddMobile")]
        public IActionResult Post([FromBody] Mobile mobile)
        {
            try
            {
                int result = service.AddMobile(mobile);
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

        // PUT api/<MobileController>/5
        [HttpPut]
        [Route("UpdateMobile")]
        public IActionResult Put([FromBody] Mobile mobile)
        {
            try
            {
                int result = service.UpdateMobile(mobile);
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

        // DELETE api/<MobileController>/5
        [HttpDelete]
        [Route("DeleteMobile/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteMobile(id);
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
