using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Shopping
{
   public  class MgHelp:Volo.Abp.Application.Services.ApplicationService, ImgHelp
    {
        

        public  string ImgHelper(IFormFile file)
        {
            string rootdir = AppContext.BaseDirectory.Split(@"\bin\")[0];
            string fname = DateTime.Now.ToString("yyyyMMddHHmmssffff") + System.IO.Path.GetExtension(file.FileName);
            var path = rootdir + @"\Upload\" + fname;
            using (System.IO.FileStream fs = System.IO.File.Create(path))
            {
                file.CopyTo(fs);
                fs.Flush();//清空文件流
            }
            return "http://localhost:8067/" + fname;//将能访问新文件的网址回传给前端


        }
    }
}
