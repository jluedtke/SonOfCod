using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class NewsletterControllerTests
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_MailingList_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var result = controller.MailingList();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_List_MailingList_Test()
        {
            //Arrange
            ViewResult mailingListView = new NewsletterController().MailingList() as ViewResult;

            //Act
            var result = mailingListView.ViewData.Model;

            //Assert
            Assert.IsType<List<Recipient>>(result);
        }
    }
}

