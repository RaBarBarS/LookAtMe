//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc.Infrastructure;
//using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Mvc;
//using LookAtMe.Controllers;
//using NUnit.Framework;
//using Moq;

//namespace LookAtMe.UnitTests
//{
//    [TestFixture]
//    public class Test
//    {

//        [Test]
//        public void SkillController_ReturnOK()
//        {
//            ILogger<SkillController> logger = Mock.Of<ILogger<SkillController>>();
//            Controllers.SkillController skillController;
//            skillController = new SkillController(logger);

//            var result = skillController.Skill();
//            var okResult = (IStatusCodeActionResult)result;

//            Assert.IsNotNull(result);
//            Assert.True(result is OkObjectResult);
//            Assert.AreEqual(200, okResult);
//        }
//    }
//}
