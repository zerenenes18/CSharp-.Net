using MultiThreading.MailProviders.Base;
using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.MailProviders
{
    public class SmtpProvider : BaseProvider
    {
        public override async Task Send(MailObject mailObject)
        {
            await Task.Delay(100);
            LogManager.Default.Log($"SmtpMail has sent to => {mailObject.To}");
        }
    }
}
