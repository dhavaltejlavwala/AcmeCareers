using System;
using System.Web.Mvc;
using AcmeCareers.Controllers;
using AcmeCareers.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcmeCareers.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckIndexPageView()
        {
            var homeController = new HomeController();
            var result = homeController.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);

        }

        [TestMethod]
        public void JobApplicationSubmit()
        {
            
        }


    }
}
