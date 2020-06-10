using System;
using FirstResponsiveWebAppMcCloud;
using FirstResponsiveWebAppMcCloud.Models;
using Xunit;
using Xunit.Sdk;
using FirstResponsiveWebAppMcCloud.Controllers;
using System.Web.Mvc;

namespace ResponsiveWebAppUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void NameEntered()
        {   
            // Arrange
            string UserName = "Nikki";

            string expected = "Nikki";
            string actual;

            AgeCheckModel nameTest = new AgeCheckModel();

            // Act
            actual = (UserName);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void AgeMathTesting()
        {
            // Arrange
            DateTime BirthDate = new DateTime(1991, 05, 21);
            DateTime CheckDate = new DateTime(2020, 12, 31);
            int ageTest = (CheckDate - BirthDate).Days/365;
            int expected = 29;
            int actual;

            AgeCheckModel calcAge = new AgeCheckModel();

            // Act
            actual = ageTest;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestController()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.Null(result);
        }
    }
}
