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
        [Test,
            TestCase ("abcd1234",false),
            TestCase("irf@uni - corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
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

        [Test,
            TestCase("sdJKasdy",false), //nincsszám
            TestCase("SDKJASD2", false), //nincs kisbetű
            TestCase("sdjkasd2", false),  //nincs nagybetű
            TestCase("sdJK2as", false),  //rövid
            TestCase("sdJK2asX", true), //ok

            //"A jelszó legalább 8 karakter hosszú kell legyen, csak az angol ABC betűiből és számokból állhat, és tartalmaznia kell legalább egy kisbetűt, egy nagybetűt és egy számot.")
            ]
        public void TestValidatePassword(string password, bool exceptedResult) 
        {
            // Arrange
            var accountController = new AccountController();
            // Act
            var actualResult = accountController.ValidatePassword(password);
            // Assert
            Assert.AreEqual(exceptedResult,actualResult);
        }
    }
}
