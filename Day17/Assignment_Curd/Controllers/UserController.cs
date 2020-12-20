using Assignment_Curd.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Curd.Controllers
{
    public class UserController : Controller
    {
        MyDbDataContext db,ct;
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("UserLogin");
        }

        
        // GET: User/Create
        public ActionResult UserRegistration()
        {
            User reg = new User();
            ct = new MyDbDataContext();
            var c = (from City in ct.Cities select City);
            List<SelectListItem> li = new List<SelectListItem>();
            foreach(var x in c)
            {
                SelectListItem st = new SelectListItem();
                st.Value = x.CityId.ToString();
                st.Text = x.CityName;
                li.Add(st);
            }
            reg.UserCity = li;
            return View(reg);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult UserRegistration(User regUser)
        {
            try
            {

                db = new MyDbDataContext();
                UserReg reg = new UserReg();
                reg.UserName = regUser.UserName;
                reg.UserFullName = regUser.UserFullName;
                reg.Password = regUser.UserPassword;
                reg.UserPhone = Convert.ToInt64(regUser.UserPhone);
                reg.UserEmail = regUser.UserEmail;
                reg.UserCityId = regUser.CityName;
                
                db.UserRegs.InsertOnSubmit(reg);
                db.SubmitChanges();
                return RedirectToAction("UserLogin");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Update
        public ActionResult Update(String id="")
        {
            //id = Session["LoginInfo"].ToString();
            User u = new User();
            ct = new MyDbDataContext();
            var c = (from City in ct.Cities select City);
            List<SelectListItem> li = new List<SelectListItem>();
            foreach (var x in c)
            {
                SelectListItem st = new SelectListItem();
                st.Value = x.CityId.ToString();
                st.Text = x.CityName;
                li.Add(st);
            }
            u.UserCity = li;
            var ud = ct.UserRegs.SingleOrDefault(x=>x.UserName==id);
            if (ud!=null)
            {
                u.UserName = ud.UserName;
                u.UserFullName = ud.UserFullName;
                u.UserEmail = ud.UserEmail;
                u.UserPhone = Convert.ToString(ud.UserPhone);

            }
            return View(u);
        }

        // POST: User/Update
        [HttpPost]
        public ActionResult Update(string id, User regUser)
        {
            try
            {
                db = new MyDbDataContext();
                UserReg ud = db.UserRegs.Single(x => x.UserName == id);
                
                ud.UserFullName = regUser.UserFullName;
                ud.Password = regUser.UserPassword;
                ud.UserPhone = Convert.ToInt64(regUser.UserPhone);
                ud.UserEmail = regUser.UserEmail;
                ud.UserCityId = regUser.CityName;

                
                    
                db.SubmitChanges();

                return RedirectToAction("UserHome");
            }
            catch
            {
                return View();
            }
        }

               // GET: User/Login
        public ActionResult UserLogin()
        {
            User l = new User();
            //var obj = Request.Cookies.AllKeys;

            //l.UserName = 
            return View(l);
        }

        // POST: User/Login
        [HttpPost]
        public ActionResult UserLogin(User login)
        {
            
            try
            {
                User l = new User();
                ct = new MyDbDataContext();
                var c = ct.UserRegs.SingleOrDefault(z=>(z.UserName==login.UserName&&z.Password==login.UserPassword));
                if (c != null) {
                    //if (login.RememberMe==true)
                    //{
                    //    string uname = login.UserName.ToString();
                        
                    //    HttpCookie userInfo = new HttpCookie("userInfo");
                    //    userInfo[uname] = login.UserPassword;
                        
                    //    userInfo.Expires.AddDays(20);
                    //    Response.Cookies.Add(userInfo);
                    //}
                    
                    Session["LoginInfo"] = c.UserName;
                    return RedirectToAction("UserHome");
                   
                }
                else {
                    ViewBag.Invalid = "Invalid Login Cradentials";
                    return RedirectToAction("UserLogin");
                }
            }
            catch
            {
                return View();
            }
        }
        // GET: User/Home
        public ActionResult UserHome()
        {
            if (Session["LoginInfo"] != null)
            {
                User l = new User();
                string lname = Session["LoginInfo"].ToString();
                ct = new MyDbDataContext();
                var c = ct.UserRegs.SingleOrDefault(z => (z.UserName == lname));
                l.UserFullName = c.UserFullName;
                l.UserName = c.UserName;
               if (lname != null)
                    return View(l);
               else
                    return RedirectToAction("UserLogin");
            }
            else
                return RedirectToAction("UserLogin");
        }
        
    }
}
