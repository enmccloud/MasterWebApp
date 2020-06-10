using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ViewReturnTest()
        {
            // Arrange
            string UserName = "Nikki";

            string expected = "Nikki";
            string actual;

            // Act
            actual = UnitTest1.AgeCheckModel(UserName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
