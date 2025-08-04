using Microsoft.AspNetCore.Mvc;
using Myapp.BusinessLayer.Interface;
using Myapp.DataAccess.Models.Dtos.CustomersDtos;

namespace Myapp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUserServices _services;

        public CustomerController(IUserServices services)
        {
            this._services = services;
        }

        // Post : /api/Customer/createUser
        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser([FromBody]CreateUserRequestDto requestDto)
        {
            var userCreateData = await _services.createUserAsync(requestDto);

            if(userCreateData == null)
            {
                return BadRequest(new {message = "Unable to Create!"});
            }

            return Created(" ",new { Created = userCreateData });
        }

        // Get : /api/Customer/getAllCustomer
        [HttpGet("getAllCustomer")]
        public async Task<IActionResult> getAllCustomer()
        {
            var customerDetails = await _services.getAllAsync();

            if(customerDetails == null)
            {
                return NotFound(new {message = "Unble to Reach!"});
            }

            return Ok(new {Customers = customerDetails});
        }

        // Get: /api/Customer/getById
        [HttpGet("getById/{id:Guid}")]
        public async Task<IActionResult>getById([FromRoute] Guid id)
        {
            var customerId = await _services.getByIdAsync(id);
             if(customerId == null)
            {
                return NotFound(new {message = "Data is not Found!"});
            }
             return Ok(customerId);
        }
    }
}
