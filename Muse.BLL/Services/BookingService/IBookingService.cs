using Ardalis.Result;
using Muse.BLL.Filters;
using Muse.DTO.BookingDtos;

namespace Muse.BLL.Services.BookingService;

public interface IBookingService
{
    Task<Result<bool>> AddAsync(AddBookingDto dto);
    Task<PagedResult<List<BookingDto>>> GetAllUserBookings(BookingFilter filter);
}