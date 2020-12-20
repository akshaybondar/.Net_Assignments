using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace MyApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return RedirectToAction("/Index.cshtml");
        }
    }
    public class EmployeeController : Controller
        {

            MyDbDataContext db;
            // GET: Employee
            public ActionResult Index()
            {
                List<Emp> emplist = new List<Emp>();
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emplist.Add(new Emp { EmpNo = (int)dr["EmpNo"], EmpName = (string)dr["Name"], Basic = (decimal)dr["Basic"], DeptNo = (int)dr["DeptNo"] });
                }
                cn.Close();

                return View(emplist);

            }


            // GET: Employee/Details/5
            public ActionResult Details(int id = 0)
            {
                Emp e1 = new Emp();

                //e1.EmpNo = 101;
                //e1.EmpName = "Rajnikant";
                //e1.Basic = 5000000;
                //e1.DeptNo = 555;
                db = new MyDbDataContext();
                Employee e1e1 = db.Employees.SingleOrDefault(emp => emp.EmpNo == id);
                if (e1e1 != null)
                {
                    e1.EmpNo = e1e1.EmpNo;
                    e1.EmpName = e1e1.Name;
                    e1.Basic = e1e1.Basic;
                    e1.DeptNo = e1e1.DeptNo;

                }
                return View(e1);

            }


            // GET: Employee/Edit/5
            public ActionResult Edit(int id)
            {
                Emp e1 = new Emp();


                db = new MyDbDataContext();
                Employee e1e1 = db.Employees.SingleOrDefault(emp => emp.EmpNo == id);
                if (e1e1 != null)
                {
                    e1.EmpNo = e1e1.EmpNo;
                    e1.EmpName = e1e1.Name;
                    e1.Basic = e1e1.Basic;
                    e1.DeptNo = e1e1.DeptNo;

                }
                return View(e1);
            }

            // POST: Employee/Edit/5
            [HttpPost]
            public ActionResult Edit(int id, Emp e1)
            {
                try
                {

                    db = new MyDbDataContext();
                    Employee e1e1 = db.Employees.SingleOrDefault(emp => emp.EmpNo == id);
                    if (e1e1 != null)
                    {
                        e1e1.EmpNo = e1.EmpNo;
                        e1e1.Name = e1.EmpName;
                        e1e1.Basic = e1.Basic;
                        e1e1.DeptNo = e1.DeptNo;
                        db.SubmitChanges();
                    }
                    return RedirectToAction("Details/" + e1.EmpNo);

                }
                catch
                {
                    return View();
                }
            }
            // GET: Employee/Create
            public ActionResult Create()
            {
                Emp objEmp = new Emp();
                return View(objEmp);
            }


            // POST: Employee/Create
            //sEmployees/Create
            [HttpPost]
            public ActionResult Create(Emp objEmp)
            {
                try
                {
                    // TODO: Add insert logic here
                    db = new MyDbDataContext();
                    Employee e1 = new Employee();
                    e1.EmpNo = objEmp.EmpNo;
                    e1.Name = objEmp.EmpName;
                    e1.Basic = objEmp.Basic;
                    e1.DeptNo = objEmp.DeptNo;

                    db.Employees.InsertOnSubmit(e1);
                    db.SubmitChanges();
                    return RedirectToAction("Details/" + objEmp.EmpNo);
                }
                catch
                {
                    return View();
                }
            }

            // GET: Employee/Delete/5
            public ActionResult Delete(int id)
            {
                Emp e1 = new Emp();


                db = new MyDbDataContext();
                Employee e1e1 = db.Employees.SingleOrDefault(emp => emp.EmpNo == id);
                if (e1e1 != null)
                {
                    e1.EmpNo = e1e1.EmpNo;
                    e1.EmpName = e1e1.Name;
                    e1.Basic = e1e1.Basic;
                    e1.DeptNo = e1e1.DeptNo;

                }
                return View(e1);
                //return View();
            }

            // POST: Employee/Delete/5
            [HttpPost]
            public ActionResult Delete(int id, Emp e1)
            {
                db = new MyDbDataContext();
                Employee e1e1 = db.Employees.SingleOrDefault(emp => emp.EmpNo == id);
                try
                {

                    if (e1e1 != null)
                    {
                        db.Employees.DeleteOnSubmit(e1e1);
                        db.SubmitChanges();
                    }

                    return RedirectToAction("Details");
                }
                catch
                {
                    return View();
                }
            }
        }
    }
