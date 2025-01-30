using Muse.DAL.Models;
using Muse.DTO.PermissionDtos;
using Riok.Mapperly.Abstractions;

namespace Muse.BLL.Mappers;

[Mapper]
public static partial class PermissionMapper
{
    public static List<PermissionDto> MapToDto(this List<Permission> permissions)
    {
        var res = new List<PermissionDto>();

        foreach (var permission in permissions)
        {
            var perm = new PermissionDto
            {
                Id = permission.Id,
                Value = permission.Value,
                Name = permission.Translations.FirstOrDefault()?.Name
            };

            res.Add(perm);
        }

        return res;
    }

    public static PermissionDto MapToDto(this Permission permission)
    {
        var dto = permission.MapToDto();

        dto.Name = permission.Translations!.First().Name;

        return dto;
    }
    
    
    private static partial PermissionDto MapModelToDto(this Permission permission);

}