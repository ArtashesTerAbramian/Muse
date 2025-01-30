using Muse.DAL.Models;
using Muse.DTO;
using Riok.Mapperly.Abstractions;

namespace Muse.BLL.Mappers;

[Mapper]
public static partial class ErrorMapper
{
    public static partial ErrorModelDto MapToDto(this Error error);
    public static partial List<ErrorModelDto> MapToDto(this List<Error> error);
}