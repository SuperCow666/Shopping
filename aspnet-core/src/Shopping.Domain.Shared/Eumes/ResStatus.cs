using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Eumes
{
   public enum ResStatus
    {
        成功=0,
        登录失败 = 30006,
        数据库添加失败 = 10002,
        修改失败 = 1003,
        删除失败 = 10004,
        查询失败 = 10005,
        微信端接口错误 = 40002
    }
}
