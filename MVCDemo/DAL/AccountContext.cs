using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext()
            : base("AccountContext")
        {
            
        }

        public DbSet<sysUserEntity> SysUsers { get; set; }
        public DbSet<SysRoleEntity> SysRole { get; set; }
        public DbSet<SysUserRoleEntity> SysUserRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}