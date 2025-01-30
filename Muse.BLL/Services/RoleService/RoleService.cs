using Ardalis.Result;
using Microsoft.EntityFrameworkCore;
using Muse.BLL.Filters;
using Muse.BLL.Mappers;
using Muse.BLL.Services.ErrorService;
using Muse.DAL;
using Muse.DAL.Models;
using Muse.DTO.RoleDtos;

namespace Muse.BLL.Services.RoleService;

public class RoleService : IRoleService
{
    private readonly AppDbContext _db;
    private readonly IErrorService _errorService;

    public RoleService(AppDbContext db, IErrorService errorService)
    {
        _db = db;
        _errorService = errorService;
    }

    public async Task<Result<RoleDto>> GetById(long id)
    {
        var role = await _db.Roles
            .Include(x => x.Translations.OrderByDescending(x => x.LanguageId))
            .Include(x => x.Permissions)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (role is null)
        {
            return Result.NotFound();
        }

        return role.MapToDto();
    }

    public async Task<PagedResult<List<RoleDto>>> GetAll(RoleFilter filter)
    {
        var query = _db.Roles
            .Include(x => x.Translations.OrderByDescending(x => x.LanguageId))
            .AsQueryable();

        var entities = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<RoleDto>>(await filter.GetPagedInfoAsync(query), entities.MapToDto());
    }


    private void UpdateRolePermissions(Role role, List<long> permissionIds)
    {
        //add
        foreach (var permissionId in permissionIds)
        {
            if (!role.Permissions!.Select(x => x.PermissionId).Contains(permissionId))
            {
                role.Permissions!.Add(new RolePermission
                {
                    RoleId = role.Id,
                    PermissionId = permissionId
                });
            }
        }

        //delete
        foreach (var permission in role.Permissions!)
        {
            if (!permissionIds.Contains(permission.PermissionId))
            {
                _db.Remove(permission);
            }
        }
    }
}