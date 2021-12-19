using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [Test
            ]
        public void TestValidateEmail(string email, bool exceptedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email); //hívd meg a vezérlő ValidateEmail függvényét a bemenő email paraméter értékével,és egy változóba tárold le a függvényhívás eredményét.

            // Assert
            Assert.AreEqual(exceptedResult, actualResult);
        }
    }
}
