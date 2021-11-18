using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Shopping.Eumes;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenLogin : ControllerBase
    {
        private IIds4Service ids4Service;
        private IConfiguration _configuration;
        public TokenLogin(IIds4Service _ids4Service, IConfiguration configuration)
        {
            ids4Service = _ids4Service;
            _configuration = configuration;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ResData<string>> GetIdsTokenAsync(string userName, string userPwd)
        {
            Ids4Service ids4Service = new Ids4Service(_configuration);
            string token = await ids4Service.GetIdsTokenAsync(userName, userPwd);
            if (!string.IsNullOrEmpty(token))
            {

                return new ResData<string>() { Status = ResStatus.成功, Msg = "获取token成功", Info = token };

            }
            return ResData<string>.Error("后台接口授权失败", null, ResStatus.微信端接口错误);
        }
    }
}