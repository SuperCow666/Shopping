using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;
namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        [HttpGet]

        public ActionResult Show()
        {
            logger.Debug("大牙项目进度");
            logger.Info("项目登录");

            return Ok(new { name = "枣庄市" });


        }

    }
}
