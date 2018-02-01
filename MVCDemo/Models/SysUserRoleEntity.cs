using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class SysUserRoleEntity
    {
        public int ID { get; set; }
        public int SysUserID { get; set; }
        public int SysRoleID { get; set; }

        public virtual sysUserEntity SysUser { get; set; }

        public virtual SysRoleEntity SysRoleEntity { get; set; }
    }
}