using Muse.DAL.Models;
using Muse.DTO.ServiceDtos;
using Riok.Mapperly.Abstractions;

namespace Muse.BLL.Mappers;

[Mapper]
public static partial class ServiceMapper
{
    public static ServiceDto MapToDto(this Service service)
    {
        var dto = service.ServiceMapToDto();

        dto.Name = service.Translations.First().Name;
        dto.Description = service.Translations.FirstOrDefault()?.Description;

        return dto;
    }

    private static partial ServiceDto ServiceMapToDto(this Service service);
    public static partial List<ServiceDto> MapToDto(this List<Service> services);
}