using Ardalis.Result;
using Microsoft.AspNetCore.Mvc;
using Muse.BLL.Filters;
using Muse.BLL.Services.BookingService;
using Muse.DTO;
using Muse.DTO.BookingDtos;

namespace Muse.Api.Controllers;

public class BookingController : ApiControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }

    [HttpPost("add-booking")]
    public async Task<Result<bool>> AddBookingAsync([FromBody] AddBookingDto dto)
    {
        return await _bookingService.AddAsync(dto);
    }

    [HttpGet("get-all-by-token")]
    public async Task<PagedResult<List<BookingDto>>> GetBookingsByIdAsync([FromBody] BookingFilter filter)
    {
        return await _bookingService.GetAllUserBookings(filter);
    }
}