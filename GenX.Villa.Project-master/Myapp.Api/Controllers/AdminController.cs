using Microsoft.AspNetCore.Mvc;
using Myapp.BusinessLayer.Interface;
using Myapp.DataAccess.Models.Dtos.AdminDtos;

namespace Myapp.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IHotelManagement _hotelAdmin;

        public AdminController(IHotelManagement hotelManagement)
        {
            this._hotelAdmin = hotelManagement;
        }

        // POST :api/Admin/createRoom
        [HttpPost("createRoom")]
        public async Task<IActionResult> createRooms([FromBody]RoomRequestDto requestDto)
        {
            if(requestDto == null)
            {
                return BadRequest(new {message = "Requested Data should not been a Null!"});
            }

            var CreateRoom = await _hotelAdmin.CreateRoomAsync(requestDto);

            if(CreateRoom == null)
            {
                return BadRequest(new { message  = "Unable to reach the Data"});
            }
            return Created("", new { message = "Room created", data = CreateRoom });
        }

        // Get : /api/Admin/getAllRooms
        [HttpGet("getAllRooms")]
        public async Task<IActionResult> getAllRoom()
        {
            var getAllValues = await _hotelAdmin.GetAllAsync();
            if(getAllValues == null && !getAllValues.Any())
            {
                return NotFound(new {message = "Data is not found!"});
            }
            return Ok(new {Rooms = getAllValues});
        }

        // Get : /api/Admin/getById/{id:Guid}
        [HttpGet("getById/{id:Guid}")]
        public async Task<IActionResult> getById([FromRoute] Guid id)
        {
            var GetById = await _hotelAdmin.GetByIdAsync(id);

            if(GetById == null)
            {
                return BadRequest(new {message = $"ID : {id} not found." });
            }

            return Ok(new { room = GetById});
        }
    }
}
