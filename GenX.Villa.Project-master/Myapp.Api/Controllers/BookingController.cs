using Microsoft.AspNetCore.Mvc;
using Myapp.BusinessLayer.Interface;
using Myapp.DataAccess.Models.Dtos.Booking;
using Myapp.DataAccess.Models.Dtos.Payment;

namespace Myapp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices _bookingServices;

        public BookingController(IBookingServices bookingServices)
        {
            this._bookingServices = bookingServices;
        }

        //Post : /api/booking
        [HttpPost("booking")]
        public async Task<IActionResult> BookingDetails([FromBody] CreateBookingDto bookingDto)
        {
            var bookingDetails = await _bookingServices.CreateBookingDetailsAsync(bookingDto);
            if(bookingDetails == null)
            {
                return BadRequest(new {message = "Data is Required!"});
            }

            return Created("/api/bookings/" + bookingDetails.Id, bookingDetails);

        }

        // Post : /api/payment
        [HttpPost("payment")]
        public async Task<IActionResult> paymentStatus([FromBody]PaymentDto paymentDto)
        {
            var paymentDetail = await _bookingServices.paymentStatusAsync(paymentDto);
            if(paymentDetail == null)
            {
                return NotFound(new {message = "Unable to Save the Data!"});
            }

            return Ok(paymentDetail);
        }


    }
}
