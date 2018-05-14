using System;
using System.Web.Mvc;
using AcmeCareers.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcmeCareers.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            JobInfoController controller = new JobInfoController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
