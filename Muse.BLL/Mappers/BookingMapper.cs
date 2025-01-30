using Muse.DAL.Models;
using Muse.DTO;
using Muse.DTO.BookingDtos;
using Riok.Mapperly.Abstractions;

namespace Muse.BLL.Mappers;

[Mapper]
public static partial class BookingMapper
{
    public static partial BookingDto MapToDto(this Booking error);
    public static partial List<BookingDto> MapToDto(this List<Booking> error);
}