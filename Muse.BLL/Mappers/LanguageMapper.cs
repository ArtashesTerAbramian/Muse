using Muse.DAL.Models;
using Muse.DTO;
using Riok.Mapperly.Abstractions;

namespace Muse.BLL.Mappers;

[Mapper]
public static partial class LanguageMapper
{
    public static partial LanguageDto MapToDto(this Language district);
    public static partial List<LanguageDto> MapToDto(this List<Language> districts);
}