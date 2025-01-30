using Ardalis.Result;
using Microsoft.EntityFrameworkCore;
using Muse.BLL.Enums;
using Muse.BLL.Filters;
using Muse.BLL.Mappers;
using Muse.BLL.Services.ErrorService;
using Muse.BLL.Services.UserService;
using Muse.DAL;
using Muse.DAL.Models;
using Muse.DTO.BookingDtos;

namespace Muse.BLL.Services.BookingService;

public class BookingService : IBookingService
{
    private readonly AppDbContext _db;
    private readonly IErrorService _errorService;
    private readonly IUserSessionService _userSessionService;

    public BookingService(AppDbContext db, IErrorService errorService, IUserSessionService userSessionService)
    {
        _db = db;
        _errorService = errorService;
        _userSessionService = userSessionService;
    }

    public async Task<Result<bool>> AddAsync(AddBookingDto dto)
    {
        var serviceWithSpecifications = await _db.Services
            .Where(x => x.Id == dto.ServiceWithSpecifications.ServiceId)
            .Include(x => x.ServiceSpecifications)
            .Select(x => new
            {
                ServiceId = x.Id,
                ServiceSpecifications = x.ServiceSpecifications
                    .Where(spec => dto.ServiceWithSpecifications.ServiceSpecificationIds.Contains(spec.Id))
                    .Select(spec => spec.Id)
            })
            .FirstOrDefaultAsync();

        if (serviceWithSpecifications == null || !serviceWithSpecifications.ServiceSpecifications.Any())
        {
            return Result.NotFound("Service or Service Specifications not found");
        }

        var bookings = serviceWithSpecifications.ServiceSpecifications
            .Select(specId => new Booking
            {
                UserId = dto.UserId,
                Date = dto.Date,
                ServiceId = serviceWithSpecifications.ServiceId,
                ServiceSpecificationId = specId,
                StatusId = (long)BookingStatusEnum.Confirmed // TODO
            })
            .ToList();


        await _db.Bookings.AddRangeAsync(bookings);

        await _db.SaveChangesAsync();

        return true;
    }

    public async Task<PagedResult<List<BookingDto>>> GetAllUserBookings(BookingFilter filter)
    {
        var query = _db.Bookings.AsQueryable();
        var bookings = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<BookingDto>>(await filter.GetPagedInfoAsync(query),bookings.MapToDto());
    }
  
}