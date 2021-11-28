using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public interface IEmailService
    {
        void SendEmail(string backGroundJobType, string startTime);
    }
}
