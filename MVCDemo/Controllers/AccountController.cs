using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.DAL;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext db = new AccountContext();
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View(db.SysUsers);
        }

        public ActionResult Details(int id)
        {
            sysUserEntity sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }

        //创建
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(sysUserEntity sysUser)
        {
            db.SysUsers.Add(sysUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            var sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }

        [HttpPost]
        public ActionResult Edit(sysUserEntity sysUser)
        {
            db.Entry(sysUser).State=EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmde(int id)
        {
            sysUserEntity sysUser = db.SysUsers.Find(id);
            db.SysUsers.Remove(sysUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string email = fc["inputEmail3"];
            string password = fc["inputPassword3"];
            var user = db.SysUsers.FirstOrDefault(s => s.Email == email && s.PassWord == password);
            if (user!=null)
            {
                ViewBag.LoginState = user.UserName+ "登录成功";
            }
            else
            {
                ViewBag.LoginState = "登录失败";
            }

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
	}
}