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
    public class UnitTestSkill
    {
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

        [TestMethod]
        public void SkillControllerID_ReturnOK()
        {
            ILogger<SkillController> logger = Mock.Of<ILogger<SkillController>>();
            LookAtMe.Controllers.SkillController skillController;
            skillController = new SkillController(logger);

            var result = skillController.Skill("R");

            Assert.IsNotNull(result);
            Assert.IsTrue(result is OkObjectResult);
            Assert.AreEqual(200, ((ObjectResult)result).StatusCode);
        }

        [TestMethod]
        public void SkillControllerID_ReturnNotFound()
        {
            ILogger<SkillController> logger = Mock.Of<ILogger<SkillController>>();
            LookAtMe.Controllers.SkillController skillController;
            skillController = new SkillController(logger);

            var result = skillController.Skill("I like trains.");

            Assert.IsNotNull(result);
            Assert.IsTrue(result is NotFoundObjectResult);
            Assert.AreEqual(404, ((ObjectResult)result).StatusCode);
        }
    }
}
