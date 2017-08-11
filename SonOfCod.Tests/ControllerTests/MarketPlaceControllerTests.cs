using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class MarketPlaceControllerTests
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            MarketplaceController controller = new MarketplaceController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
