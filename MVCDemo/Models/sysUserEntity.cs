using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class sysUserEntity
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }

        public virtual ICollection<SysUserRoleEntity> SysUserRole { get; set; } 
    }
}