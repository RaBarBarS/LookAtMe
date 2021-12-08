using Microsoft.VisualStudio.TestTools.UnitTesting;
using LookAtMe.Models;
using Moq;
using Microsoft.Extensions.Logging;
using LookAtMe.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace LookAtMeUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void SkillController_ReturnOK()
        {
            ILogger<SkillController> logger = Mock.Of<ILogger<SkillController>>();
            LookAtMe.Controllers.SkillController skillController;
            skillController = new SkillController(logger);

            var result = skillController.Skill();

            Assert.IsNotNull(result);
            Assert.IsTrue(result is OkObjectResult);
            Assert.AreEqual(200, ((ObjectResult)result).StatusCode);
        }
    }
}
