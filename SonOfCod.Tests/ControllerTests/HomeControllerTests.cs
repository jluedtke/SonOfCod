using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
