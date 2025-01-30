using Muse.DAL.Models;
using Muse.DTO.RoleDtos;
using Riok.Mapperly.Abstractions;

namespace Muse.BLL.Mappers;

[Mapper]
public static partial class RoleMapper
{
    public static List<RoleDto> MapToDto(this List<Role> roles)
    {
        var res = new List<RoleDto>();

        foreach (var role in roles)
        {
            var roleDto = new RoleDto
            {
                Id = role.Id,
                Name = role.Translations!.FirstOrDefault()?.Name!
            };

            res.Add(roleDto);
        }

        return res;
    }

    public static RoleDto MapToDto(this Role role)
    {
        var dto = RoleMapToDto(role);

        dto.PermissionIds = role?.Permissions?.Select(x => x.PermissionId).ToList();
        dto.Name = role!.Translations!.First().Name;
        return dto;
    }

    private static partial RoleDto RoleMapToDto(this Role role);
}