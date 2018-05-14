using AcmeCareers.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCareers.Controllers
{
    public class JobInfoController : Controller
    {
        // GET: JobInfo
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            //var viewModel = new JobInfo();
            var query = from job in db.JobInfo
                        select job;
            return View(query);
        }

        // GET: JobInfo/Details
        public string Details()
        {
            var db = new ApplicationDbContext();
            //var viewModel = new JobInfo();
            var query = (from job in db.JobInfo
                        select new
                        {
                            title = job.Title,
                            location = job.Location ,
                            contactPerson = job.ContactPerson
                        }).ToList();
            var JsonObject = JsonConvert.SerializeObject(query.ToArray());
            return JsonObject;
        }

        // GET: JobInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobInfo/Create
        [HttpPost]
        public ActionResult Create(JobInfo Model)
        {
            try
            {
                if (Model != null && !String.IsNullOrEmpty(Model.Title) && !String.IsNullOrEmpty(Model.Location) && !String.IsNullOrEmpty(Model.ContactPerson))
                {

                    var Title = Model.Title;
                    var Location = Model.Location;
                    var ContactPerson = Model.ContactPerson;
                    var db = new ApplicationDbContext();
                    var InsertJobInfo = new JobInfo { Title = Title, Location = Location, ContactPerson = ContactPerson };
                    db.JobInfo.Add(InsertJobInfo);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return RedirectToAction("Create");
            }

            return RedirectToAction("Create");
        }

        // GET: JobInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JobInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
