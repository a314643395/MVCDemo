using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class SysRoleEntity
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }

        public ICollection<SysUserRoleEntity> SysUserRole { get; set; } 
    }
}