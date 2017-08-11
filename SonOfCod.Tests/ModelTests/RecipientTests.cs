using SonOfCod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SonOfCod.Tests.ModelTests
{
    public class RecipientTests
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var rec = new Recipient();
            rec.FirstName = "Jared";

            //Act
            var result = rec.FirstName;

            //Assert
            Assert.Equal("Jared", result);
        }
    }
}
