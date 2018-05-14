using AcmeCareers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCareers.Controllers
{
    public class HomeController : Controller
    {
        private IApplicationDbContext db;

        public HomeController()
        {
            db = new ApplicationDbContext();
        }

        public HomeController(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }


        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            IEnumerable<SelectListItem> items = db.JobInfo.Select(c => new SelectListItem
            {
                Value = c.Title + "|" + c.JobId,
                Text = c.Title

            });
            ViewBag.JobTitleList = items;

            return View();
        }

        [HttpPost]
        public ActionResult Index(JobApplication Model)
        {
            try
            {
                if (ModelState.IsValid && Model != null && !String.IsNullOrEmpty(Model.Name) && !String.IsNullOrEmpty(Model.Email) && !String.IsNullOrEmpty(Model.JobTitle)) //&& !String.IsNullOrEmpty(Model.Comments) && ((Model.JobId.JobId.GetType() == typeof(int)))
                {
                    char[] splitchar = { '|' };
                    var splitJobTitle = Model.JobTitle.Split(splitchar);

                    var Name = Model.Name;
                    var Email = Model.Email;
                    var JobTitle = splitJobTitle[0];
                    var Comments = Model.Comments;
                    var JobId = Convert.ToInt16(splitJobTitle[1]);
                    var CurrentTime = DateTime.Now;

                    var db = new ApplicationDbContext();
                    var InsertApplicationForm = new JobApplication { Name = Name, Email = Email, JobTitle = JobTitle, Comments = Comments, AppDateTime = CurrentTime, JobId = JobId };
                    db.JobApplication.Add(InsertApplicationForm);
                    db.SaveChanges();

                    var SendEmail = new SendEmail(Model);

                    ViewBag.Class = "success";
                    ViewBag.Strong = "Thank you";
                    ViewBag.Message = " for your application";
                    return PartialView("_AppAck");

                }
            }
            catch (Exception ex)
            {
                ViewBag.Class = "danger";
                ViewBag.Strong = "Error";
                ViewBag.Message = "Something went wrong! <br /> Please Try Again <br /> <br />" + ex.ToString();
                return PartialView("_AppAck");
            }

            ViewBag.Class = "danger";
            ViewBag.Strong = "Error";
            ViewBag.Message = "Invalid data! <br /> Please Try Again <br /> <br />";
            return PartialView("_AppAck");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}