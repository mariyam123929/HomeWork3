using System;
using System.Collections.Generic;
using HomeWork3.Data.Models;

namespace ControllerFirst.Data.Models;


public class Role
{
    public string RoleName { get; set; }
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}