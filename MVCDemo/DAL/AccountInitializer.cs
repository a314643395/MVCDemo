using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.DAL
{
    public class AccountInitializer:DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            var sysUsers = new List<sysUserEntity>
            {
                new sysUserEntity{UserName = "jon",Email = "jon@qq.com",PassWord = "1"},
                new sysUserEntity{UserName="gin",Email = "gin@qq.com",PassWord = "2"}
            };
            sysUsers.ForEach(s=>context.SysUsers.Add(s));
            context.SaveChanges();

            var sysRoles=new List<SysRoleEntity>
            {
                new SysRoleEntity{RoleName = "管理员",RoleDesc ="这是个管理员"},
                new SysRoleEntity{RoleName = "员工",RoleDesc = "这是员工"}
            };
            sysRoles.ForEach(s=>context.SysRole.Add(s));
            context.SaveChanges();
        }
    }
}