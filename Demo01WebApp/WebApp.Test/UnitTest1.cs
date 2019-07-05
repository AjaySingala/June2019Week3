using Demo01WebApp.Controllers;
using Demo01WebApp.Models;
//using Demo01WebApp.Models.Repositories;
using System;
using WebApp.Test.Repositories;
using Xunit;

namespace WebApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var repo = new CustomerRepositoryTest();
            var ctr = new CustomerController(repo);
            var retVal = ctr.Get(901);

            var viewRes = ((Microsoft.AspNetCore.Mvc.ViewResult)retVal);
            Assert.Equal(1, 1);
            Assert.IsType<Customer>(viewRes.Model);
            
        }
    }
}
