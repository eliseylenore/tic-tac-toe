using Xunit;
using TicTacToe.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TicTacToe.Controllers.Tests
{
    public class StatsControllerTests
    {
        [Fact()]
        public void IndexTest()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}