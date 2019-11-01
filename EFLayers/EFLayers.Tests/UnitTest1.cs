using EFLayers.Controllers;
using EFLayers.Models;
using EFLayers.Models.Repositories;
using EFLayers.Tests.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFLayers.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCustomerDetails_ReturnsCustomer()
        {
            // Arrange.
            ICustomerRepository repo = new CustomerTestRepository();
            CustomersController controller = new CustomersController(repo);

            var expected = "John";

            // Act.
            var result = controller.Details(102);
            var fname = ((Customer)(result.Result as ViewResult).Model).Firstname;

            // Assert.
            Assert.AreEqual(expected, fname);
        }
    }
}
