﻿namespace Muse.DAL.Models;

public class RolePermission : BaseEntity
{
    public long RoleId { get; set; }
    public long PermissionId { get; set; }

    public Role Role { get; set; }
    public Permission Permission { get; set; }
}